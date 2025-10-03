using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketController : MonoBehaviour
{
    [SerializeField] private float playerLvl;
    [SerializeField] private GameObject MarketContent;
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
    public void SpawnItems()
    {
        for (int i = 0; i < marketItemsCount; i++)
        {
            float rarity = Random.Range(0f, 1f);
            switch (playerLvl)
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
        Instantiate(common_ChampionItemList[Random.Range(0, common_ChampionItemList.Count)],MarketContent.transform);
    }
    private void SpawnNormal()
    {
        Instantiate(normal_ChampionItemList[Random.Range(0, normal_ChampionItemList.Count)], MarketContent.transform);
    }
    private void SpawnRare()
    {
        Instantiate(rare_ChampionItemList[Random.Range(0, rare_ChampionItemList.Count)], MarketContent.transform);
    }
    private void SpawnEpic()
    {
        Instantiate(epic_ChampionItemList[Random.Range(0, epic_ChampionItemList.Count)], MarketContent.transform);
    }
    private void SpawnLegendary()
    {
        Instantiate(legendary_ChampionItemList[Random.Range(0, legendary_ChampionItemList.Count)], MarketContent.transform);
    }

}
