using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WeaponConfig Data", menuName = "Weapon Config Data", order = 51)]
public class WeaponConfig : ScriptableObject, IShipEquipment
{
    [SerializeField]
    float baseRange = 100;
    [SerializeField]
    float baseDamageModifer = 1;
    [SerializeField]
    string weaponName = "Default";




    public float BaseDamageModifier
    {
        get => baseDamageModifer;
        private set => baseDamageModifer = value;
    }

    public string WeaponName
    {
        get => weaponName;
        private set => weaponName = value;
    }

    public void Activate(IShip _target, IShip _source)
    {
        ShipStats temp = _target.ShipStats;
        Debug.Log(temp.HP);
        temp.HP -= Mathf.FloorToInt(baseDamageModifer * _source.BaseDamage);
        Debug.Log(temp.HP);
        _target.ShipStats = temp;
    }

}
