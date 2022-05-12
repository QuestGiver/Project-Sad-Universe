using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnOrder
{
    private Queue<ICommanderInfo> _turnOrder = new Queue<ICommanderInfo>();
    public ICommanderInfo CurrentTurnHolder;

    public void InitializeTurnOrder(List<ICommanderInfo> _ParticipantList)
    {
        SortFleets(_ParticipantList);
        foreach  (ICommanderInfo commander in _ParticipantList)
        {
            _turnOrder.Enqueue(commander);
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


    public List<ICommanderInfo> SortFleets(List<ICommanderInfo> _PartipantList)
    {
        List<ICommanderInfo> SortedList = new List<ICommanderInfo>();

        float highest;
        int indexOfHighest;

        for (int i = 0; i < _PartipantList.Count - 1; i++)
        {
            highest = 0;
            indexOfHighest = 0;
            for (int j = 0; j < _PartipantList.Count - 1; j++)
            {
                if (!SortedList.Contains(_PartipantList[j]))
                    if (ReturnFleetInitiative(_PartipantList[j].SubmitFleet()) > highest)
                    {
                        highest = ReturnFleetInitiative(_PartipantList[j].SubmitFleet());
                        indexOfHighest = j;
                    }
            }
            SortedList.Add(_PartipantList[indexOfHighest]);
        }

        return SortedList;
    }

    ///returns the mean average initiative of a fleet
    public float ReturnFleetInitiative(List<ICombatObject> _fleet)
    {
        float result = 0;
        foreach (ICombatObject ship in _fleet)
        {
            result += ship.ReportInitiative();
        }

        return result/_fleet.Count;
    }

    public void QueueCombatParticipant(ICommanderInfo _combatObject)
    {
        _turnOrder.Enqueue(_combatObject);
    }
}
