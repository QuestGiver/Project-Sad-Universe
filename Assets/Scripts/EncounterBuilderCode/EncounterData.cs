using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
//Intented to allow the creation of a prebuilt encounter
[CreateAssetMenu(fileName = "New Encounter Data", menuName = "ScriptableObjects/Encounter", order = 1)]
public class EncounterData : ScriptableObject
{
    public List<ICommanderInfo> ParticipantList = new List<ICommanderInfo>();
    public float FieldSize = 1000;
}
