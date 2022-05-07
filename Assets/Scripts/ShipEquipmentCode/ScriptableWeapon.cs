using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon Item", menuName = "ScriptableObjects/WeaponEquipment", order = 1)]
public class ScriptableWeapon : Equipment
{
    public override void ActivateEquipment(ICombatObject _source)
    {
        
    }

    public override void ProcessHeat(ICombatObject _source)
    {
       
    }
}
