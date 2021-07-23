using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShip
{
    void UpdatePosition();
    void CheckPowerDist();
    void ShipDestroy();

    //properties
    public ShipAttributes ShipAttributes { get; set; }
    public ShipStats ShipStats { get;  set; }
    public int BaseDamage { get; set; }
    public string ShipName { get; set; }





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
    private int size;//(total space for upgrades/weapons and size class of ship/this stat and the shield generator rating and slot size determine max shield strength)
    private int engines;
    private int heatManagement;
    private int structure;
    private int affinity;
    private int aI;
    private int armorRating;

    //I was trying something and created these, not sure when i'll use them but i'm keeping them for when balance testing needs to happen.
    public int Engines { get => engines; set => engines = value; }
    public int HeatManagement { get => heatManagement; set => heatManagement = value; }
    public int Structure { get => structure; set => structure = value; }
    public int Affinity { get => affinity; set => affinity = value; }
    public int AI { get => aI; set => aI = value; }
    public int ArmorRating { get => armorRating; set => armorRating = value; }
    public int Size { get => size; set => size = value; }

    public ShipAttributes(
        int _engines,
        int _heatManagement,
        int _structure,
        int _affinity,
        int _aI,
        int _armorRating,
        int _size
        )
    {
        engines = _engines;//(evasion and speed)
        heatManagement = _heatManagement;//(cool down times)
        structure = _structure;//(hit points)
        affinity = _affinity;//(Boarding Defense and buff/debuff multiplier)
        aI = _aI;//(Luck and misc determinants)
        armorRating = _armorRating;//(Resistance to damage)
        size = _size;//(total space for upgrades/weapons and size class of ship/this stat and the shield generator rating and slot size determine max shield strength)

    }


}


[System.Serializable]
public struct ShipStats
{
    private int pwrSupplyMax;//The maximum, and probably normal, Charge regeneration ammount
    private int hpMax;
    private int hP;
    private int speedMax;
    private int speed;
    private int chargeMax;
    private int charge;
    private int evasion;
    private int evasionMax;
    private int dissipation;
    private int dissipationMax;
    private int luck;
    private int luckMax;
    private int resistance;
    private int resistanceMax;
    private int heat;
    private int heatMax;
    private int shields;
    private int shieldMax;
    private int pwrSupply;

    public ShipStats(
        int _hpMax,
        int _hP,
        int _speedMax,
        int _speed,
        int _chargeMax,
        int _charge,
        int _evasionMax,
        int _evasion,
        int _dissipationMax,
        int _dissipation,
        int _luckMax,
        int _luck,
        int _resistanceMax,
        int _resistance,
        int _heatMax,
        int _heat,
        int _shieldMax,
        int _shields,
        int _pwrSupplyMax,
        int _pwrSupply
        )
    {
        hpMax = _hpMax;
        hP = _hP;
        speedMax = _speedMax;
        speed = _speed;
        chargeMax = _chargeMax;
        charge = _charge;
        evasion = _evasion;
        evasionMax = _evasionMax;
        dissipation = _dissipation;
        dissipationMax = _dissipationMax;
        luck = _luck;
        luckMax = _luckMax;
        resistance = _resistance;
        resistanceMax = _resistanceMax;
        heat = _heat;
        heatMax = _heatMax;
        shields = _shields;
        shieldMax = _shieldMax;
        pwrSupply = _pwrSupply;
        pwrSupplyMax = _pwrSupplyMax;
    }

    //I was trying something and created these, not sure when i'll use them but i'm keeping them for when balance testing needs to happen.
    public int HpMax { get => hpMax; set => hpMax = value; }
    public int HP { get => hP; set => hP = value; }
    public int SpeedMax { get => speedMax; set => speedMax = value; }
    public int Speed { get => speed; set => speed = value; }
    public int ChargeMax { get => chargeMax; set => chargeMax = value; }
    public int Charge { get => charge; set => charge = value; }
    public int Evasion { get => evasion; set => evasion = value; }
    public int EvasionMax { get => evasionMax; set => evasionMax = value; }
    public int Dissipation { get => dissipation; set => dissipation = value; }
    public int DissipationMax { get => dissipationMax; set => dissipationMax = value; }
    public int Luck { get => luck; set => luck = value; }
    public int LuckMax { get => luckMax; set => luckMax = value; }
    public int Resistance { get => resistance; set => resistance = value; }
    public int ResistanceMax { get => resistanceMax; set => resistanceMax = value; }
    public int Heat { get => heat; set => heat = value; }
    public int HeatMax { get => heatMax; set => heatMax = value; }
    public int Shields { get => shields; set => shields = value; }
    public int ShieldMax { get => shieldMax; set => shieldMax = value; }
    public int PwrSupply { get => pwrSupply; set => pwrSupply = value; }
    public int PwrSupplyMax { get => pwrSupplyMax; set => pwrSupplyMax = value; }
}
