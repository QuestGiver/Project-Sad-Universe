﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour, IShip
{
    IShipEquipment ShipAttackBehavior;

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
    public void ShipAttack()
    {
        ShipAttackBehavior.Activate();
    }

    //check power distibution and update relevant statistics
    public void CheckPowerDist()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        ShipAttackBehavior = new ShipWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
