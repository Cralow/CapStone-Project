using System.Collections.Generic;
using UnityEngine;

public class MarketController : MonoBehaviour
{
    [SerializeField] private GameObject MarketContent;
    private List<GameObject> ChampionsInMarket = new List<GameObject>();
    private float marketItemsCount = 5;

    [SerializeField] private List<GameObject> common_ChampionItemList = new List<GameObject>();
    [SerializeField] private List<GameObject> normal_ChampionItemList = new List<GameObject>();
    [SerializeField] private List<GameObject> rare_ChampionItemList = new List<GameObject>();
    [SerializeField] private List<GameObject> epic_ChampionItemList = new List<GameObject>();
    [SerializeField] private List<GameObject> legendary_ChampionItemList = new List<GameObject>();

    private void Awake()
    {
        SpawnItems();
    }
    //alla fine del turno 
    public void SpawnItems()
    {
        if (ChampionsInMarket != null)
        {
            foreach(GameObject item in ChampionsInMarket)
            {
                Destroy(item);
            }
        }
        for (int i = 0; i < marketItemsCount; i++)
        {
            float rarity = Random.Range(0f, 1f);
            switch (PlayerInventory.Instance.playerLvl)
            {
                case 0:
                    SpawnMarketItems(80, 17, 2, 0.1f, 0.01f);
                    break;

                case 1:
                    SpawnMarketItems(70, 25, 4, 0.7f, 0.3f);
                    break;

                case 2:
                    SpawnMarketItems(60, 32, 9, 1, 0.4f);
                    break;

                case 3:
                    SpawnMarketItems(50, 40, 15, 1.5f, 0.45f);
                    break;
                    
                case 4:
                    SpawnMarketItems(40, 50, 20, 2, 0.5f);
                    break;

                case 5:
                    SpawnMarketItems(30, 60, 30, 3, 0.6f);
                    break;

                case 6:
                    SpawnMarketItems(15, 45, 50, 9, 0.8f);
                    break;

                case 7:
                    SpawnMarketItems(5, 35, 60, 20, 1);
                    break;

                case 8:
                    SpawnMarketItems(2, 20, 40, 20, 3);
                    break;

                case 9:

                    SpawnMarketItems(1, 10, 20, 30, 5);
                    break;

                case 10:

                    SpawnMarketItems(1, 1, 10, 40, 10);
                    break;

                 case >= 11:
                    SpawnMarketItems(1, 1, 1, 10, 10 + PlayerInventory.Instance.playerLvl);
                    break;

            }
        }


    }
                                           
                     
    
    private void SpawnMarketItems(
    float commonPercent,
    float normalPercent,
    float rarePercent,
    float epicPercent,
    float legendaryPercent)
    {
        float total = commonPercent + normalPercent + rarePercent + epicPercent + legendaryPercent;

        if (total <= 0f)
        {
            return;
        }

        float rarity = Random.value;
        float cumulative = 0f;

        cumulative += commonPercent / total;
        if (rarity < cumulative) { SpawnCommon(); return; }

        cumulative += normalPercent / total;
        if (rarity < cumulative) { SpawnNormal(); return; }

        cumulative += rarePercent / total;
        if (rarity < cumulative) { SpawnRare(); return; }

        cumulative += epicPercent / total;
        if (rarity < cumulative) { SpawnEpic(); return; }

        cumulative += legendaryPercent / total;
        if (rarity < cumulative) { SpawnLegendary(); return; }

        // Fallback di sicurezza
        SpawnCommon();
    }

    private void SpawnCommon()
    {
       var a = Instantiate(common_ChampionItemList[Random.Range(0, common_ChampionItemList.Count)],MarketContent.transform);
        ChampionsInMarket.Add(a);
    }
    private void SpawnNormal()
    {
        var a = Instantiate(normal_ChampionItemList[Random.Range(0, normal_ChampionItemList.Count)], MarketContent.transform);
        ChampionsInMarket.Add(a);
    }
    private void SpawnRare()
    {
        var a = Instantiate(rare_ChampionItemList[Random.Range(0, rare_ChampionItemList.Count)], MarketContent.transform);
        ChampionsInMarket.Add(a);
    }
    private void SpawnEpic()
    {
        var a = Instantiate(epic_ChampionItemList[Random.Range(0, epic_ChampionItemList.Count)], MarketContent.transform);
        ChampionsInMarket.Add(a);
    }
    private void SpawnLegendary()
    {
        var a = Instantiate(legendary_ChampionItemList[Random.Range(0, legendary_ChampionItemList.Count)], MarketContent.transform);
        ChampionsInMarket.Add(a);
    }

}
