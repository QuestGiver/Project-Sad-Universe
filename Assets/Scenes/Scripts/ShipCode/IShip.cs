using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShip
{

    Ship returnShip();
    void UpdatePosition();
    void CheckPowerDist();
    void ShipDestroy();
    void AttributesToStats();
    float activeModUnitComponent(float _activeMod);

    //properties
    public ShipAttributes ShipAttributes { get; set; }
    public ShipStats ShipStats { get;  set; }
    public float BaseDamage { get;}
    public string ShipName { get;}
    




    /*
     * Or should these be replaced with
     * methods that simply give the UI information
     * such as current speedMax or the hp?
     * 
     */


}

[System.Serializable]
public struct ShipAttributes
{
    [SerializeField]
    private float size,//(total space for upgrades/weapons and size class of ship/this stat and the shield generator rating and slot size determine max shield strength)
    engines,
    heatManagement,
    structure,
    affinity,
    aI,
    armorRating;

    //I was trying something and created these, not sure when i'll use them but i'm keeping them for when balance testing needs to happen.
    public float Engines { get => engines; set => engines = value; }
    public float HeatManagement { get => heatManagement; set => heatManagement = value; }
    public float Structure { get => structure; set => structure = value; }
    public float Affinity { get => affinity; set => affinity = value; }
    public float AI { get => aI; set => aI = value; }
    public float ArmorRating { get => armorRating; set => armorRating = value; }
    public float Size { get => size; set => size = value; }

    public ShipAttributes(
        float _engines,
        float _heatManagement,
        float _structure,
        float _affinity,
        float _aI,
        float _armorRating,
        float _size
        )
    {
        engines = _engines;//(evasion and speed)
        heatManagement = _heatManagement;//(heat management)
        structure = _structure;//(hit points)
        affinity = _affinity;//(Boarding Defense/how familiar the crew is with the ship and buff/debuff multiplier)
        aI = _aI;//(Luck and misc determinants)
        armorRating = _armorRating;//(Resistance to damage)
        size = _size;//(total space for upgrades/weapons and size class of ship/this stat and the shield generator rating and slot size determine max shield strength)

    }


}


[System.Serializable]
public struct ShipStats
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
