using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//UI intended to display information, rather than take input
//will observe this class
public static class TurnOrder
{
    public static int Round;//Current Round
    private static int turn;//Current turn
    public static int Reactions;//number of reactions left to cycle through

    private static List<Ship> roundOrder;
    public static List<Ship> RoundOrder { get => roundOrder; private set => roundOrder = value; }
    public static int Turn
    {
        get => turn;

        set
        {
            turn = value;
            DetermineOrder();
        }
    }

    /// <summary>
    /// Automatically determines the turn order of all ships
    /// </summary>
    public static void DetermineOrder()
    {

    }
}
