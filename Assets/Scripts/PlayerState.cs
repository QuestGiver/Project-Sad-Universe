using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerState
{
    public static List<UniversalData> fleet;
    public static EncounterParticipant CommanderInfoPassThrough()
    {
        List<ICombatObject> ships = new List<ICombatObject>();
        foreach (UniversalData ship in fleet)
        {
            DefaultCombatPuppet puppet = ScriptableObject.CreateInstance<DefaultCombatPuppet>();
            ships.Add(puppet.ImplementUniversalData(ship));
        }

        EncounterParticipant encounterParticipant = ScriptableObject.CreateInstance<EncounterParticipant>();
        encounterParticipant.Ships = ships;
        encounterParticipant.PlayerRelationship = EncounterAIState.PLAYER;
        return encounterParticipant;
    }

}
