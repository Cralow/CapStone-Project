using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarketUpgradesController : MonoBehaviour
{
    [Header("RICHIEDE MARKETCONTROLLER in parent")]
    [SerializeField]private float updateStaticCost = 2;
    private MarketController marketController;

    [SerializeField] private float expStaticCost = 4;
    [SerializeField] private float[] expToLevelUp;

    private void Awake()
    {
        marketController = GetComponent<MarketController>();
        //aggiorna ui
        PlayerInventory.Instance.SetPlayerExpToNextLvl((int)expToLevelUp[PlayerInventory.Instance.playerLvl]);
    }
    //Chiamata da ButtonUi: "Aggiorna";
    public void UI_BuyMarketUpdate()
    {
        if(PlayerInventory.Instance.playerMoney > updateStaticCost)
        {
            PlayerInventory.Instance.playerMoney -= updateStaticCost;
            marketController.SpawnItems();
        }
    }
    //Chiamata da ButtonUi: "Upgrade";
    public void UI_BuyExperience()
    {
        if (PlayerInventory.Instance.playerMoney > expStaticCost)
        {
            PlayerInventory.Instance.AddExp(expToLevelUp[PlayerInventory.Instance.playerLvl], expStaticCost);//il costo è 4 ma anche la exp da aggiungere 
            PlayerInventory.Instance.SetPlayerExpToNextLvl((int)expToLevelUp[PlayerInventory.Instance.playerLvl]);

            PlayerInventory.Instance.playerMoney -= expStaticCost;
        }
    }
}
