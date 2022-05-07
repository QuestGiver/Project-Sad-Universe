using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPuppetFactory : MonoBehaviour
{
    public List<ScriptableWeapon> Weapons = new List<ScriptableWeapon>();
    private void Awake()
    {
        
    }

    public DefaultCombatPuppet GenerateShip()
    {
        DefaultCombatPuppet puppet = ScriptableObject.CreateInstance<DefaultCombatPuppet>();
        puppet.GenerateBaseAttributes();
        puppet.GenerateBaseStats();
        puppet.currentState = puppet.Stats;
        puppet.universalName = "NPC Ship Made At: " + System.DateTime.Now.ToString();
        GenerateWeaponLoadout(puppet);
        return puppet;
    }

    private void GenerateWeaponLoadout(DefaultCombatPuppet puppet)
    {
        ScriptableWeapon weapon = Weapons[0];

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


