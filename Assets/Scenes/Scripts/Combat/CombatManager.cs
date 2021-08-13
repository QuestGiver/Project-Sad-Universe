using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//This class is intended to be a nexus between a few dedicated static classes
//so that it can properly manage what occurs in combat. 
//UI or Animators will watch this class in order to determine when to act.
public class CombatManager : MonoBehaviour
{
    private int totalShips = 0;
    public CommanderShell TESTplayer; //testing only
    public CommanderShell TESTenemy; //testing only

    //---------------------------------------------------------------------------------------
    /*This portion of code is supposed to externally recieve information about commanders
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
            foreach  (CommanderInfo _commander in value)
            {
                totalShips += _commander.CommanderFleet.Count;

                foreach (Ship _ship in _commander.CommanderFleet)
                {
                    RegisterShips(_ship);
                }
            }

        }
    }

    public void SubmitCommander(CommanderInfo _commanderInfo)
    {
        Participants.Add(_commanderInfo);
    }
    //---------------------------------------------------------------------------------------
    /*
     *This portion of code is supposed to internally recieve information about individual ships for
     *easy access. It should help facilitate tracking which ships die and/if they are 
     *revived.
     */
    private Dictionary<float, Ship> shipIDPairs = new Dictionary<float, Ship>();
    private void RegisterShips(Ship _ship)
    { 
        shipIDPairs.Add(_ship.ShipAttributes.Engines, _ship);
    }
    //----------------------------------------------------------------------------------------





    // Start is called before the first frame update
    //Start is also where the combat manager makes sure all references to variables are put together is required
    void Start()
    {

    }

    //Main Combat Funtions Below----------------------------------------------------------------------------------------

    //Process Turn
    public void TurnUpdate()
    {
        EquipmentProcess(TESTenemy.commanderInfo.CommanderFleet[0], TESTplayer.commanderInfo.CommanderFleet[0], TESTplayer.commanderInfo.CommanderFleet[0].weaponConfigs[0]);
    }

    //must be tied to a UI object to meet MVC requirements
    public void EquipmentProcess(IShip _target, IShip _source, IShipEquipment _equipment)
    {
        _equipment.Activate(_target, _source);
    }







}
