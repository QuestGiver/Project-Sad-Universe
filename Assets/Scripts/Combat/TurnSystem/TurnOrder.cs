using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnOrder
{
    public List<ICombatObject> SortShips(List<ICombatObject> _combatObjectList)
    {
        List<ICombatObject> SortedList = new List<ICombatObject>();

        ICombatObject highest;

        for (int i = 0; i < _combatObjectList.Count - 1; i++)
        {
            highest = 0;
            for (int j = 0; j < _combatObjectList.Count - 1; j++)
            {
                if (!SortedList.Contains(_combatObjectList[j]))
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
