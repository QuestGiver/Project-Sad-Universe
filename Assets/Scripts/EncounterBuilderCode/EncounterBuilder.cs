using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is intented to pull data from addressable assets or scriptable objects for plug and play encounter creation
public class EncounterBuilder : MonoBehaviour
{

    public EncounterData BuildRandomEncounter()
    {
        EncounterData Data = ScriptableObject.CreateInstance<EncounterData>();
        //logic pending
        return Data;
    }

    public List<ICombatObject> GenerateFleet(int _fleetSize)
    {

        List<ICombatObject> combatants = new List<ICombatObject>();

        for (int i = 0; i < _fleetSize; i++)
        {
            //pull from scriptable object
        }

        return combatants;
    }

}
