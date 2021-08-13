using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Commander Data", menuName = "Commander Data", order = 51)]
public class CommanderInfo : ScriptableObject, ICommanderInfo
{
    public List<Ship> CommanderFleet = new List<Ship>();
    public string Name;

    public void SubmitFleet(CombatManager _combatManager)
    {
        if (CommanderFleet.Count > 0)
        {
            if (_combatManager != null)
            {
                _combatManager.SubmitCommander(this);
            }
        }
    }


}
