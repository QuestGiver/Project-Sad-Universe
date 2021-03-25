using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommanderInfo
{
    public List<Ship> CommanderFleet = new List<Ship>();

    public void SubmitFleet()
    {
        if(CommanderFleet.Count > 0)
        CombatManager.RoundOrder.AddRange(CommanderFleet);
    }
}
