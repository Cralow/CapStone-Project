using System.Collections;
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
    //chiamata nel pulsante aggiorna in market e alla fine del turno 
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
                    if(rarity < 0.8f)
                    {
                        SpawnCommon();
                    }
                    else if(rarity < 0.95f)
                    {
                        SpawnNormal();
                    }
                    else
                    {
                        SpawnRare();
                    }
                        break;





                  case 1:
                      break;
                  case > 2:
                      break;  
             }
        }
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
