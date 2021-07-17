using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShipEquipment
{
    void Activate();
    EquipmentType GetEquipType(EquipmentType _type);

}

public enum EquipmentType
{
    WEAPON = 1, POWERPLANT = 2
}