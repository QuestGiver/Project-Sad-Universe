using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EncounterBuilder
{

    public static EncounterData testData;

    public static EncounterData BuildRandomEncounter()
    {
        return testData;
    }

    public List<ICombatObject> GenerateFleet(int _size)
    {
        List<ICombatObject> combatants = new List<ICombatObject>();

        for (int i = 0; i < _size; i++)
        {
            combatants.Add(CombatPuppetFactory.GenerateShip());
        }

        return combatants;
    }

    public EncounterAI GenerateAI(int _fleetSize)
    {
        return new EncounterAI( GenerateFleet(1), EncounterAIState.NEUTRAL);
    }
}
