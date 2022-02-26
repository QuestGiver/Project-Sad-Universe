using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterAI : MonoBehaviour
{
    public List<ICombatObject> ships = new List<ICombatObject>();
    public EncounterAIState playerRelationship;

    public EncounterAI(List<ICombatObject> _ships, EncounterAIState _playerRelationship)
    {
        ships = _ships;
        playerRelationship = _playerRelationship;
    }
}

public enum EncounterAIState
{
    HOSTILE = 0,
    NEUTRAL = 1,
    FRIENDLY = 2
}