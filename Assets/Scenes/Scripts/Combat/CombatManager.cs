using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{

    private CommanderInfo participants;

    private static Dictionary<int, Ship> shipIDPairs = new Dictionary<int, Ship>();


    private static List<Ship> roundOrder;
    public static List<Ship> RoundOrder { get => roundOrder; private set => roundOrder = value; }


    // Start is called before the first frame update
    void Start()
    {

    }


    //Functions below connect to UI Assets
    private void InitializeTurnOrder()//unordered stack of ships goes in
    {

    }

    public static void RegisterShips(Ship _ship)
    {
        shipIDPairs.Add(_ship.s);
    }





}
