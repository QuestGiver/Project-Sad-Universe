using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Base Ship Stats", menuName = "ScriptableObjects/BaseShipStats", order = 1)]
public class BaseStats : ScriptableObject//the upgradable portion of the ships
{

    [SerializeField]
    HitPoints _myHitPoints;

    [SerializeField]
    public float
        maxPwrSupply,
        maxSpeed,
        maxCharge,
        maxEvasion,
        maxDissipation,
        maxLuck,
        maxHeat,
        maxRadarRange;

    public HitPoints MyHitPoints { get => _myHitPoints; set => _myHitPoints = value; }

    public BaseStats(float _maxPwrSupply,
                               float _maxSpeed,
                               float _maxCharge,
                               float _maxEvasion,
                               float _maxDissipation,
                               float _maxLuck,
                               float _maxHeat,
                               float _maxRadarRange)
    {
        maxPwrSupply = _maxPwrSupply;
        maxSpeed = _maxSpeed;
        maxCharge = _maxCharge;
        maxEvasion = _maxEvasion;
        maxDissipation = _maxDissipation;
        maxLuck = _maxLuck;
        maxHeat = _maxHeat;
        maxRadarRange = _maxRadarRange;
    }

}
