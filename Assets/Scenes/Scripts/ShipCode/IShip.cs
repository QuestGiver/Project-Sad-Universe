using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShip
{

    Ship returnShip();
    void UpdatePosition();
    void CheckPowerDist();
    void ShipDestroy();
    void AttributesToStats();
    float getActiveModifierUnitValue(float _activeMod);

    //properties
    public ShipAttributes ShipAttributes { get; set; }
    public ShipStats ShipStats { get;  set; }
    public float BaseDamage { get;}
    public string ShipName { get;}
    




    /*
     * Or should these be replaced with
     * methods that simply give the UI information
     * such as current speedMax or the hp?
     * 
     */


}



