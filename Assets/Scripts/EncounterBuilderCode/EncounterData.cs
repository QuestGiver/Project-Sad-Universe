using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Encounter Data", menuName = "ScriptableObjects/Encounter", order = 1)]
public class EncounterData : ScriptableObject
{
    public List<EncounterAI> AIList = new List<EncounterAI>();
    public float FieldSize = 1000;

}
