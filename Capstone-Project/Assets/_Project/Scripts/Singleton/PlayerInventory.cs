using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : GenericSingleton<PlayerInventory>
{
    public float playerMoney;
    public int playerLvl;
    public float playerExperience;
    public int playerExpToNextLvl { get; private set; }


    protected override bool ShouldBeDestroyedOnLoad()
    {
        return true;
    }
    public void SetPlayerExpToNextLvl(int expNeeded)
    {
        playerExpToNextLvl = expNeeded;
    }
    public void AddMoney(float amount)
    {
       playerMoney += amount;
    }
    public void AddExp(float expToLevelUp,float exp)
    {
        playerExperience += (int) exp;

        while (expToLevelUp >0 && playerExperience >= expToLevelUp)
        {
            playerExperience -= expToLevelUp;
            playerLvl++;
        }

    }
}
