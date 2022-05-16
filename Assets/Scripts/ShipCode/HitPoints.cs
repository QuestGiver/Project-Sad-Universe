using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A general purpose health tracking class
public class HitPoints : MonoBehaviour
{
    private float maxHP;
    private float currentHP;
    private float maxShields;
    private float currentShields;
    private float resistance;

    public float GetMaxHP()
    {
        return maxHP;
    }

    public void SetMaxHP(float value)
    {
        maxHP = value;
    }

    public float GetCurrentHP()
    {
        return currentHP;
    }

    public void SetCurrentHP(float value)
    {
        currentHP = value;
    }

    public float GetMaxShields()
    {
        return maxShields;
    }

    public void SetMaxShields(float value)
    {
        maxShields = value;
    }

    public float GetCurrentShields()
    {
        return currentShields;
    }

    public void SetCurrentShields(float value)
    {
        currentShields = value;
    }

    public float GetResistance()
    {
        return resistance;
    }

    public void SetResistance(float value)
    {
        resistance = value;
    }

    public HitPoints(float maxHP,
                              float currentHP,
                              float maxShields,
                              float currentShields,
                              float resistance)
    {
        SetMaxHP(maxHP);
        SetCurrentHP(currentHP);
        SetMaxShields(maxShields);
        SetCurrentShields(currentShields);
        SetResistance(resistance);
    }
}
