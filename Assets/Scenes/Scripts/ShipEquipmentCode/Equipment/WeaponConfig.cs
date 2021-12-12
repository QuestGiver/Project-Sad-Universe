using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New WeaponConfig Data", menuName = "Weapon Config Data", order = 51)]
public class WeaponConfig : ScriptableObject, IShipEquipment
{
    [SerializeField]
    float heatGenerated = 10;
    [SerializeField]
    float coolDown = 1;//turns before it can be used again. 1 means usable every turn.
    [SerializeField]
    float chargeUp = 1;//delay before it can be used measured in turns. 1 means usuable every turn
    [SerializeField]
    float baseRange = 100;
    [SerializeField]
    float baseSpeed = 10;
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
    public float CoolDown { get => coolDown; set => coolDown = value; }
    public float ChargeUp { get => chargeUp; set => chargeUp = value; }
    public float HeatGenerated { get => heatGenerated; set => heatGenerated = value; }

    public void ActivateEquipment(IShip _target, IShip _source)
    {
        ProcessHeat(_source);
        _target.ShipStats.HP -= Mathf.FloorToInt(baseDamageModifer * _source.BaseDamage);
    }

    public void ProcessHeat(IShip _source)
    {
        _source.ShipStats.Heat += HeatGenerated * _source.getActiveModifierUnitValue(_source.returnShip().ActiveEquipmentMod);
    }
}
