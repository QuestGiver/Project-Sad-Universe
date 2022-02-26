using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Base Ship Stats", menuName = "ScriptableObjects/ShipStats", order = 1)]
public class BaseShipStats : ScriptableObject
{
    [SerializeField]
    public float
        maxPwrSupply,
        maxHp,
        maxSpeed,
        maxCharge,
        maxEvasion,
        maxDissipation,
        maxLuck,
        maxResistance,
        maxHeat,
        maxShield,
        maxRadarRange;

    public BaseShipStats(float _maxPwrSupply, float _maxHp, float _maxSpeed, float _maxCharge, float _maxEvasion, float _maxDissipation, float _maxLuck, float _maxResistance, float _maxHeat, float _maxShield, float _maxRadarRange)
    {
        maxPwrSupply = _maxPwrSupply;
        maxHp = _maxHp;
        maxSpeed = _maxSpeed;
        maxCharge = _maxCharge;
        maxEvasion = _maxEvasion;
        maxDissipation = _maxDissipation;
        maxLuck = _maxLuck;
        maxResistance = _maxResistance;
        maxHeat = _maxHeat;
        maxShield = _maxShield;
        maxRadarRange = _maxRadarRange;
    }

}
