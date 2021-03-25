using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo
{
    public List<Ship> PlayerFleet = new List<Ship>();

    public void SubmitFleet()
    {
        if(PlayerFleet.Count > 0)
        CombatManager.RoundOrder.AddRange(PlayerFleet);
    }
    //aspects
    //inventory
    //exp
    //renown
    //money
    //



}
