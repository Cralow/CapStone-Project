using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text playerMoney_Text;

    private void Update()
    {
        playerMoney_Text.text = PlayerInventory.Instance.playerMoney.ToString();
    }
}
