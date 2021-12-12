using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IShipEquipment
{
    void ActivateEquipment(IShip _target, IShip _source);
    void ProcessHeat(IShip _source);

    public float CoolDown { get; set; }
    public float ChargeUp { get; set; }
    public float HeatGenerated { get; set; }
}

public enum EquipmentType
{
    WEAPON = 1, POWERPLANT = 2
}