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

    private static Dictionary<int, Ship> shipIDPairs = new Dictionary<int, Ship>();
    public static Dictionary<int, Ship> ShipIDPairs { get => shipIDPairs; private set => shipIDPairs = value; }

    private static List<Ship> roundOrder;

    public CombatManager(PlayerInfo playerInfo, CommanderInfo commanderInfo, int round, int turn, int reactions)
    {
        this.playerInfo = playerInfo;
        this.commanderInfo = commanderInfo;
        Round = round;
        Turn = turn;
        Reactions = reactions;
    }

    public static List<Ship> RoundOrder { get => roundOrder; private set => roundOrder = value; }


    // Start is called before the first frame update
    void Start()
    {
        InitializeTurnOrder();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessTurn();
        ProcessRound();
    }

    private void InitializeTurnOrder()//unordered stack of ships goes in
    {

    }

    public void ProcessTurn()
    {

    }

    public void ProcessRound()
    {

    }

    public void ReactionCounter()
    {
        //event logic
    }

    public void ProcessAttack(int index, int damage)//Index should be handed to this function by UI code:  mouse over target ship->ui requests ship
    { 

    }

}
