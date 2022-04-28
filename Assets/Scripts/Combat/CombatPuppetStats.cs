using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPuppetStats
{

    private float 
        pwrSupply,
        hP,
        speed,
        charge,
        evasion,
        dissipation,
        luck,
        resistance,
        heat,
        shields,
        radarRange;

    public float PwrSupply
    {
        get
        {
            return pwrSupply;
        }
        set
        {
            pwrSupply = value;
        }
    }
    public float HP
    {
        get
        {
            return hP;
        }
        set
        {
            hP = value;
        }
    }
    public float Speed
    { 
        get 
        { 
            return speed; 
        } 
        set
        {
            speed = value;
        }
    }
    public float Charge
    {
        get { return charge; }
        set
        {
            charge = value;
        }
    }
    public float Evasion
    {
        get
        {
            return evasion;
        }
        set
        {
            evasion = value;
        }
    }
    public float Dissipation
    {
        get
        {
            return dissipation;
        }
        set
        {
            dissipation = value;
        }
    }
    public float Luck
    {
        get
        {
            return luck;
        }
        set
        {
            luck = value;
        }
    }
    public float Resistance
    {
        get
        {
            return resistance;
        }
        set
        {
            resistance = value;
        }
    }
    public float Heat
    {
        get
        {
            return heat;
        }
        set
        {
            heat = value;
        }
    }
    public float Shields
    {
        get
        {
            return shields;
        }
        set
        {
            shields = value;
        }
    }
    public float RadarRange
    {
        get
        {
            return radarRange;
        }
        set
        {
            radarRange = value;
        }
    }

    CombatPuppetStats(UniversalData _ship)
    {

    }

}
