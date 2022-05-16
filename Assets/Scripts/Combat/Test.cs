using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public List<ICombatObject> combatPuppets = new List<ICombatObject>();

    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            DefaultCombatPuppet puppet = ScriptableObject.CreateInstance<DefaultCombatPuppet>();
            //puppet.GenerateBaseAttributes();
            combatPuppets.Add(puppet);
        }

        List<float> rawInitiativeData = new List<float>();
        rawInitiativeData = SortShipsHighestToLowest(rawInitiativeData);

        int index = 0;
        foreach  (float ship in rawInitiativeData  )
        {
            Debug.Log(ship + ": " + index);
            index++;
        }
    }

    public List<float> SortShipsHighestToLowest(List<float> _combatObjectList)
    {
        List<float> SortedList = new List<float>();

        float highest;

        for (int i = 0; i < _combatObjectList.Count - 1; i++)
        {
            highest = 0;
            for (int j = 0; j < _combatObjectList.Count - 1; j++)
            {
                if(!SortedList.Contains(_combatObjectList[j]))
                if (_combatObjectList[j] > highest)
                {
                    highest = _combatObjectList[j];
                }
            }
            SortedList.Add(highest);
        }

        return SortedList;
    }
}
