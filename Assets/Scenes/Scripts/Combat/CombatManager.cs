using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This class is intended to be a nexus between a few dedicated static classes
//so that it can properly manage what occurs in combat. 
//UI or Animators will watch this class in order to determine when to act.
public class CombatManager : MonoBehaviour
{
    private int totalShips = 0;


    //---------------------------------------------------------------------------------------
    /*This portion of code is supposed to recieve information about commanders
     * and in the process also record the total number of ships for easy access.
    */
    private List<CommanderInfo> participants = new List<CommanderInfo>();

    public List<CommanderInfo> Participants {

        get
        {
            return participants;
        }

        set
        {
            participants = value;
            foreach  (CommanderInfo _ship in value)
            {
                totalShips += _ship.CommanderFleet.Count;
            }
        }
    }
    //---------------------------------------------------------------------------------------
    /*
     *This portion of code is supposed to recieve information about individual ships for
     *easy access. It should help facilitate tracking which ships die and/if they are 
     *revived.
     */
    private static Dictionary<int, Ship> shipIDPairs = new Dictionary<int, Ship>();
    public static void RegisterShips(Ship _ship)
    {
        shipIDPairs.Add(_ship.ShipAttributes.Engines, _ship);
    }
    //----------------------------------------------------------------------------------------





    // Start is called before the first frame update
    void Start()
    {

    }

    //Main Combat Funtions Below----------------------------------------------------------------------------------------


    //must be tied to a UI object to function
    public void EquipmentProcess(IShip _target, IShip _source, IShipEquipment _equipment)
    {
        _equipment.Activate(_target, _source);
    }







}
