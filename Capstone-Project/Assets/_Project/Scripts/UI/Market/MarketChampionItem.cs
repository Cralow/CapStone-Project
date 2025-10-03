using TMPro;
using UnityEngine;

public class MarketChampionItem : MonoBehaviour
{
    [SerializeField] public float cost;
    [SerializeField] public TMP_Text ItemCostText;

    private void Awake()
    {
        ItemCostText.text = cost.ToString();
    }

    public void UI_BuyItem()
    {
        if(PlayerInventory.Instance.playerMoney >= cost)
        {
            //aggiungi a inventario 
            PlayerInventory.Instance.playerMoney -= cost;
            Destroy(gameObject);
        }
    }
}
