using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IShipEquipment
{
    void Activate(IShip _target, IShip _source);

}

public enum EquipmentType
{
    WEAPON = 1, POWERPLANT = 2
}