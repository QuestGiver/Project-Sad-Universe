using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New EncounterAI", menuName = "ScriptableObjects/EncounterAI", order = 1)]
//intended to be a plug and play scriptable object for easily creating AI's from a set of options
public class EncounterParticipant : ScriptableObject, ICommanderInfo
{
    [SerializeField]
    public List<ICombatObject> Ships = new List<ICombatObject>();
    EncounterAIState playerRelationship;

    public EncounterAIState PlayerRelationship { get => playerRelationship; set => playerRelationship = value; }

    public ref List<ICombatObject> SubmitFleet()
    {
        return ref Ships;
    }
}

public enum EncounterAIState
{
    HOSTILE = 0,
    NEUTRAL = 1,
    FRIENDLY = 2,
    PLAYER = 3
}