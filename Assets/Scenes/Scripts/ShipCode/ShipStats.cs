using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShipStats
{
    [SerializeField]
    private float maxPwrSupply,//The maximum, and probably normal, Charge regeneration ammount
    pwrSupply,
    maxHp,
    hP,
    maxSpeed,
    speed,
    maxCharge,
    charge,
    maxEvasion,
    evasion,
    maxDissipation,
    dissipation,
    maxLuck,
    luck,
    maxResistance,
    resistance,
    maxHeat,
    heat,
    maxShield,
    shields;

    public ShipStats(
        float _hpMax,
        float _hP,
        float _speedMax,
        float _speed,
        float _chargeMax,
        float _charge,
        float _evasionMax,
        float _evasion,
        float _dissipationMax,
        float _dissipation,
        float _luckMax,
        float _luck,
        float _resistanceMax,
        float _resistance,
        float _heatMax,
        float _heat,
        float _shieldMax,
        float _shields,
        float _pwrSupplyMax,
        float _pwrSupply
        )
    {
        maxHp = _hpMax;
        hP = _hP;
        maxSpeed = _speedMax;
        speed = _speed;
        maxCharge = _chargeMax;
        charge = _charge;
        evasion = _evasion;
        maxEvasion = _evasionMax;
        dissipation = _dissipation;
        maxDissipation = _dissipationMax;
        luck = _luck;
        maxLuck = _luckMax;
        resistance = _resistance;
        maxResistance = _resistanceMax;
        heat = _heat;
        maxHeat = _heatMax;
        shields = _shields;
        maxShield = _shieldMax;
        pwrSupply = _pwrSupply;
        maxPwrSupply = _pwrSupplyMax;
    }

    //I was trying something and created these, not sure when i'll use them but i'm keeping them for when balance testing needs to happen.
    public float MaxHp { get => maxHp; set => maxHp = value; }
    public float HP { get => hP; set => hP = value; }
    public float MaxSpeed { get => maxSpeed; set => maxSpeed = value; }
    public float Speed { get => speed; set => speed = value; }
    public float MaxCharge { get => maxCharge; set => maxCharge = value; }
    public float Charge { get => charge; set => charge = value; }
    public float MaxEvasion { get => maxEvasion; set => maxEvasion = value; }
    public float Evasion { get => evasion; set => evasion = value; }
    public float MaxDissipation { get => maxDissipation; set => maxDissipation = value; }
    public float Dissipation { get => dissipation; set => dissipation = value; }
    public float MaxLuck { get => maxLuck; set => maxLuck = value; }
    public float Luck { get => luck; set => luck = value; }
    public float MaxResistance { get => maxResistance; set => maxResistance = value; }
    public float Resistance { get => resistance; set => resistance = value; }
    public float MaxHeat { get => maxHeat; set => maxHeat = value; }
    public float Heat { get => heat; set => heat = value; }
    public float MaxShield { get => maxShield; set => maxShield = value; }
    public float Shields { get => shields; set => shields = value; }
    public float MaxPwrSupply { get => maxPwrSupply; set => maxPwrSupply = value; }
    public float PwrSupply { get => pwrSupply; set => pwrSupply = value; }
}
