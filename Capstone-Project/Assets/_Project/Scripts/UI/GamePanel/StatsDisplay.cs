using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text playerLvl_Text;
    [SerializeField] private TMP_Text playerMoney_Text;

    [SerializeField] private TMP_Text playerExp_Text;
    [SerializeField] private TMP_Text playerExpToNextLvl_text;

    private void Update()
    {
        playerMoney_Text.text = PlayerInventory.Instance.playerMoney.ToString();
        playerLvl_Text.text = PlayerInventory.Instance.playerLvl.ToString();
        playerExp_Text.text = PlayerInventory.Instance.playerExperience.ToString();
        playerExpToNextLvl_text.text = PlayerInventory.Instance.playerExpToNextLvl.ToString();
    }
}
