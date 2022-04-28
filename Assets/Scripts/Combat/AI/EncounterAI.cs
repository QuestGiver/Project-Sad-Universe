using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New EncounterAI", menuName = "ScriptableObjects/EncounterAI", order = 1)]
public class EncounterAI : ScriptableObject, ICommanderInfo
{
    [SerializeField]
    List<ICombatObject> ships = new List<ICombatObject>();
    public EncounterAIState playerRelationship;

    public EncounterAI(List<ICombatObject> _ships, EncounterAIState _playerRelationship)
    {
        ships = _ships;
        foreach  (ICombatObject ship in ships)
        {
            ship.SetOwner(this);
        }

        playerRelationship = _playerRelationship;
    }

    public ref List<ICombatObject> SubmitFleet()
    {
        return ref ships;
    }
}

public enum EncounterAIState
{
    HOSTILE = 0,
    NEUTRAL = 1,
    FRIENDLY = 2
}