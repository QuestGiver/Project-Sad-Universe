using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private PlayerInfo playerInfo;
    private CommanderInfo commanderInfo;

    private int Round;//Current Round
    private int Turn;//Current turn
    private int Reactions;//number of reactions left to cycle through
    private List<Ship> roundOrder;
    public List<Ship> RoundOrder { get => roundOrder; private set => roundOrder = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private List<Ship> InitializeTurnOrder()//unordered stack of ships goes in
    {
        List<Ship> allShips = new List<Ship>();
        allShips.AddRange(playerInfo.PlayerFleet);
        allShips.AddRange(commanderInfo.CommanderFleet);

        foreach (Ship item in allShips)
        {
            //quicksort based on ship speed
        }


        return allShips;
    }

    private void TurnManager()//should be a coroutine
    {

    }

    private void RoundManager()//should be a coroutine
    {

    }

    private void ReactionCounter()//should be a coroutine
    {
        //event logic
    }

}
