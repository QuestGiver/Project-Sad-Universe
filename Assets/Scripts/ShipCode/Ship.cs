using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ship
{
    protected string shipName = "none";

    [SerializeField]
    protected readonly BaseShipStats baseShipStats;
    protected ShipAttributes shipAttributes;
    protected List<ShipEquipment> shipEquipment = new List<ShipEquipment>();
    protected ShipTypes shipType = ShipTypes.AS;

    public ShipAttributes ShipAttributes
    {
        get
        {
            return shipAttributes;
        }
        set
        {
            shipAttributes = value;
        }
    }
    public string ShipName
    {
        get
        {
            return shipName;
        }

        set
        {
            shipName = value;
        }
    }

    public ShipEquipment ReturnEquipmentOfType(EquipmentType _equipmentType)
    {
        foreach (ShipEquipment equipment in shipEquipment)
        {
            if (equipment.equipmentType == _equipmentType)
            {
                return equipment;
            }
        }
        throw new System.Exception("Ship: " + shipName + " has no equipment of type: " + _equipmentType);
    }

}

