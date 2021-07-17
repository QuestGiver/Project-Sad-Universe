using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ship Data", menuName = "Ship Data", order = 51)]
public class Ship : ScriptableObject, IShip
{
    public string ShipName = "Default";

    //All Equipment is stored here
    [SerializeField]
    private List<IShipEquipment> ShipEquipment = new List<IShipEquipment>();

    [SerializeField]
    private ShipStats shipStats;
    [SerializeField]
    private ShipAttributes shipAttributes;

    private int baseDamage = 20; //the base damage that any ship weapon would deal given a damage multiplier of 100%

    public ShipStats ShipStats { get => shipStats; set => shipStats = value; }
    public ShipAttributes ShipAttributes { get => shipAttributes; set => shipAttributes = value; }

    //execute ship destruction behavior
    public void ShipDestroy()
    {
        throw new System.NotImplementedException();
    }

    //DEPRICATE //update ship position on radar
    public void UpdatePosition()
    {
        throw new System.NotImplementedException();
    }



    //execute attack behavior
    public void ShipAttack(int index)
    {
        ShipEquipment[index].Activate();
    }

    //check power distibution and update relevant statistics
    public void CheckPowerDist()
    {
        throw new System.NotImplementedException();
    }


    public Ship()//default creation
    {
        ShipName = "Default";
       // ShipAttackBehaviors.Add(new ShipWeapon());
        shipStats = new ShipStats
            (
            100,//hp max
            100,//hp
            100,//speedMax
            100,//speed
            100,//chargeMax
            100,//charge
            100,//evasionMax
            100,//evasion
            100,//dissipationMax
            100,//dissipation
            100,//luckMax
            100,//luck
            100,//resistanceMax
            100,//resistance
            100,//heatMax
            100,//heat
            100,//shieldMax
            100,//shields
            100,//pwrSupplyMax
            100 //pwrSupply
            );

    }

    public Ship(string _shipName,List<IShipEquipment> _shipAttackBehavior, int _baseDamage, ShipStats _shipStats) //specific creation
    {
        ShipName = _shipName;
        ShipEquipment = _shipAttackBehavior;
        ShipStats = _shipStats;
        baseDamage = _baseDamage;
    }
}
