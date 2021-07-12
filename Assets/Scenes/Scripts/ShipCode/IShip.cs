using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShip
{
    void ShipAttack(int index);//weapon is selected via index
    void UpdatePosition();
    void CheckPowerDist();
    void ShipDestroy();
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
    public int Engines,//(evasion and speed)
    HeatManagement,//(cool down times)
    Structure,//(hit points)
    Affinity,//(Boarding Defense and buff/debuff multiplier)
    AI,//(Luck and misc determinants)
    ArmorRating,//(Resistance to damage)
    Size;//(total space for upgrades/weapons and size class of ship/this stat and the shield generator rating and slot size determine max shield strength)

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
        Engines = _engines;//(evasion and speed)
        HeatManagement = _heatManagement;//(cool down times)
        Structure = _structure;//(hit points)
        Affinity = _affinity;//(Boarding Defense and buff/debuff multiplier)
        AI = _aI;//(Luck and misc determinants)
        ArmorRating = _armorRating;//(Resistance to damage)
        Size = _size;//(total space for upgrades/weapons and size class of ship/this stat and the shield generator rating and slot size determine max shield strength)

    }

}


[System.Serializable]
public struct ShipStats
{
    public int HpMax,//max structural integrity
    HP,//current structural integrity
    SpeedMax,//maximum speed value for ship
    Speed,//Total speed after calculations
    ChargeMax,//maximum action points
    Charge,//current action points availible
    Evasion,//how evasive the ship current is
    EvasionMax,//how evasive the ship can be
    Dissipation,//how much heat the ship can currently dissipate per turn
    DissipationMax,//the maximum value the ship can obtain for dissipation
    Luck,//current critial hit chance modifier and accuracy modifier
    LuckMax,//the maximum ammount of luck the ship may have
    Resistance,//the current percentage of damage that the ships hull can resist
    ResistanceMax,//maximum resistance percentage the ship allows
    Heat,//the current heat level of the ship
    HeatMax,//The maximum ammount of heat the ship can gain before taking damage
    Shields,//The current strength of the ships shields
    ShieldMax,//The maximum strength of the ships shield, determined by "((shield generator size/ship size) * shield rating) * (100 * power distributer allocation)" //power distributor allocation should range from 0.25-2
    PwrSupply,//the rate by which Charge regenerates per turns
    PwrSupplyMax;//The maximum, and probably normal, Charge regeneration ammount


    public ShipStats(
        int hpMax,
        int hP,
        int speedMax,
        int speed,
        int chargeMax,
        int charge,
        int evasionMax,
        int evasion,
        int dissipationMax,
        int dissipation,
        int luckMax,
        int luck,
        int resistanceMax,
        int resistance,
        int heatMax,
        int heat,
        int shieldMax,
        int shields,
        int pwrSupplyMax,
        int pwrSupply
        )
    {
        HpMax = hpMax;
        HP = hP;
        SpeedMax = speedMax;
        Speed = speed;
        ChargeMax = chargeMax;
        Charge = charge;
        Evasion = evasion;
        EvasionMax = evasionMax;
        Dissipation = dissipation;
        DissipationMax = dissipationMax;
        Luck = luck;
        LuckMax = luckMax;
        Resistance = resistance;
        ResistanceMax = resistanceMax;
        Heat = heat;
        HeatMax = heatMax;
        Shields = shields;
        ShieldMax = shieldMax;
        PwrSupply = pwrSupply;
        PwrSupplyMax = pwrSupplyMax;
    }
}
