using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnOrder
{
    private Queue<ICombatObject> _turnOrder = new Queue<ICombatObject>();
    public ICombatObject CurrentTurnHolder;

    public void InitializeTurnOrder(List<ICombatObject> _combatObjectList)
    {
        SortShips(_combatObjectList);
        foreach  (ICombatObject ship in _combatObjectList)
        {
            _turnOrder.Enqueue(ship);
        }
    }

    public void StartTurn()
    {
        CurrentTurnHolder = _turnOrder.Dequeue();
    }

    public void EndTurn()
    {
        _turnOrder.Enqueue(CurrentTurnHolder);
    }

    public List<ICombatObject> SortShips(List<ICombatObject> _combatObjectList)
    {
        List<ICombatObject> SortedList = new List<ICombatObject>();

        float highest;
        int indexOfHighest;

        for (int i = 0; i < _combatObjectList.Count - 1; i++)
        {
            highest = 0;
            indexOfHighest = 0;
            for (int j = 0; j < _combatObjectList.Count - 1; j++)
            {
                if (!SortedList.Contains(_combatObjectList[j]))
                    if (_combatObjectList[j].ReportInitiative() > highest)
                    {
                        highest = _combatObjectList[j].ReportInitiative();
                        indexOfHighest = j;
                    }
            }
            SortedList.Add(_combatObjectList[indexOfHighest]);
        }

        return SortedList;
    }

    public void QueueCombatObject(ICombatObject _combatObject)
    {
        _turnOrder.Enqueue(_combatObject);
    }
}
