using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A factory for creating anything for a combat encounter that does not have a scriptable object
public class CombatPuppetFactory : MonoBehaviour
{ 

    private static void GenerateWeaponLoadout(DefaultCombatPuppet puppet)
    {
        ScriptableWeapon weapon = EquipmentPool.WeaponsPool[0];

        for (float i = 0; i < puppet.Attributes.Size; i += weapon.Size)
        {
            if ((i + weapon.Size) > (puppet.Attributes.Size))
            {
                break;
            }
            puppet.Equipment.Add(weapon);
        }
    }

}


