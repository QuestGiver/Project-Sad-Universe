using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICombatObject
{
    public void UpdatePosition();

    public ShipAttributes ShipAttributes { get;}
    public BaseShipStats ShipStats { get; set; }
    public string ShipName { get; }

}



