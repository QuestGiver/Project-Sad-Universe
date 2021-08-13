using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IShipEquipment
{
    void Activate(IShip _target, IShip _source);

    public float CoolDown { get; set; }
    public float ChargeUp { get; set; }
}

public enum EquipmentType
{
    WEAPON = 1, POWERPLANT = 2
}