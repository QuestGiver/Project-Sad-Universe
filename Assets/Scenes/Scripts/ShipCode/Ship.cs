using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : IShip
{
    public string ShipName = "Default";
    List<IShipEquipment> ShipAttackBehaviors = new List<IShipEquipment>();
    private ShipStats shipStats;
    private int baseDamage = 20; //the base damage that any ship weapon would deal given a damage multiplier of 100%

    public ShipStats ShipStats { get => shipStats; set => shipStats = value; }

    //execute ship destruction behavior
    public void ShipDestroy()
    {
        throw new System.NotImplementedException();
    }

    //update ship position on radar
    public void UpdatePosition()
    {
        throw new System.NotImplementedException();
    }

    //execute attack behavior
    public void ShipAttack(int index)
    {
        ShipAttackBehaviors[index].Activate();
    }

    //check power distibution and update relevant statistics
    public void CheckPowerDist()
    {
        throw new System.NotImplementedException();
    }


    public Ship()//default creation
    {
        ShipName = "Default";
        ShipAttackBehaviors.Add(new ShipWeapon());
        shipStats = new ShipStats
            (
            100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100
            );

    }

    public Ship(string _shipName,List<IShipEquipment> _shipAttackBehavior, int _baseDamage, ShipStats _shipStats) //specific creation
    {
        ShipName = _shipName;
        ShipAttackBehaviors = _shipAttackBehavior;
        ShipStats = _shipStats;
        baseDamage = _baseDamage;
    }
}
