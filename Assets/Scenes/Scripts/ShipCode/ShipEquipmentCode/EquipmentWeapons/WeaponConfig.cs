using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WeaponConfig Data", menuName = "Weapon Config Data", order = 51)]
public class WeaponConfig : ScriptableObject, IShipEquipment
{

    [SerializeField]
    private EquipmentType MyType = EquipmentType.WEAPON;
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
        temp.HP -= Mathf.FloorToInt(baseDamageModifer * _source.BaseDamage);
        _target.ShipStats = temp;
    }

    public EquipmentType GetEquipType(EquipmentType _type)
    {
        return _type;
    }
}
