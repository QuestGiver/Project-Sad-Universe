using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShip
{
    void ShipAttack(int index);//weapon is selected via index
    void UpdatePosition();
    void CheckPowerDist();
    void ShipDestroy();
}

public struct ShipStats
{
    public int HpMax;//max structural integrity
    public int HP;//current structural integrity
    public int SpeedMax;//maximum speed value for ship
    public int Speed;//Total speed after calculations
    public int ChargeMax;//maximum action points
    public int Charge;//current action points availible
    public int Evasion;//how evasive the ship current is
    public int EvasionMax;//how evasive the ship can be
    public int Dissipation;//how much heat the ship can currently dissipate per turn
    public int DissipationMax;//the maximum value the ship can obtain for dissipation
    public int Luck;//current critial hit chance modifier and accuracy modifier
    public int LuckMax;//the maximum ammount of luck the ship may have
    public int Resistance;//the current percentage of damage that the ships hull can resist
    public int ResistanceMax;//maximum resistance percentage the ship allows
    public int Heat;//the current heat level of the ship
    public int HeatMax;//The maximum ammount of heat the ship can gain before taking damage
    public int Shields;//The current strength of the ships shields
    public int ShieldMax;//The maximum strength of the ships shield, determined by "((shield generator size/ship size) * shield rating) * (100 * power distributer allocation)" //power distributor allocation should range from 0.25-2
    public int PwrSupply;//the rate by which Charge regenerates per turns
    public int PwrSupplyMax;//The maximum, and probably normal, Charge regeneration ammount

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
