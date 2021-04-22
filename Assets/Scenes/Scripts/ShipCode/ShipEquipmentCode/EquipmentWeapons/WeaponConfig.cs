using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WeaponConfig Data", menuName = "Weapon Config Data", order = 51)]
public class WeaponConfig : ScriptableObject, IWeaponConfig
{
    [SerializeField]
    float baseDamageModifer = 1;
    [SerializeField]
    string weaponName = "Default";



    public float BaseDamageModifier
    {
        get => baseDamageModifer;
        set => baseDamageModifer = value;
    }

    public string WeaponName
    {
        get => weaponName;
        set => weaponName = value;
    }
}
