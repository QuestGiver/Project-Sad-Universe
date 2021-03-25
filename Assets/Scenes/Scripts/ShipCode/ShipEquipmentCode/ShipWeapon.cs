using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapon : IShipEquipment
{
    public string Name = "Default";
    public float BaseDamageModifier = 1;//1 = 100%
    //sfx
    //sprite
    //projectile
    

    public void Activate()
    {
        throw new System.NotImplementedException();
    }

    public ShipWeapon(string _name, float _baseDamageModifier)//specific creation
    {
        Name = _name;
        BaseDamageModifier = _baseDamageModifier;
    }

    public ShipWeapon()//default creation
    {
        Name = "Default";
        BaseDamageModifier = 1;
    }

}
