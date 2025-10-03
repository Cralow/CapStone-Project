using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : GenericSingleton<PlayerInventory>
{
    public float playerMoney;
    protected override bool ShouldBeDestroyedOnLoad()
    {
        return true;
    }

    public void AddMoney(float amount)
    {
       playerMoney += amount;
    }
}
