using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EncounterBuilder : MonoBehaviour
{
    public CombatPuppetFactory combatPuppetFactory;

    public EncounterData BuildRandomEncounter()
    {
        EncounterData Data = ScriptableObject.CreateInstance<EncounterData>();
        Data.FieldSize = 1000;
        Data.ParticipantList.Add(GenerateAI(1));
        return Data;
    }

    public EncounterParticipant GenerateAI(int _fleetSize)
    {
        EncounterParticipant encounterParticipant = ScriptableObject.CreateInstance<EncounterParticipant>();
        encounterParticipant.Ships = GenerateFleet(_fleetSize);
        encounterParticipant.PlayerRelationship = EncounterAIState.HOSTILE;
        return encounterParticipant;
    }

    public List<ICombatObject> GenerateFleet(int _fleetSize)
    {

        List<ICombatObject> combatants = new List<ICombatObject>();

        for (int i = 0; i < _fleetSize; i++)
        {
            combatants.Add(combatPuppetFactory.GenerateShip());
        }

        return combatants;
    }

}
