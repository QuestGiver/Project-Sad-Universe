using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Equipment : ScriptableObject
{
    public abstract void ActivateEquipment(ICombatObject _source);
    public abstract void ProcessHeat(ICombatObject _source);

    public ParticleSystem particleSystem;

    [SerializeField]
    EquipmentType _equipmentType;
    [SerializeField]
    float _modifier;
    [SerializeField]
    float _coolDown;
    [SerializeField]
    float _chargeUp;
    [SerializeField]
    float _heatGenerated;
    [SerializeField]
    float _maxOverClock;
    [SerializeField]
    float _size;
    [SerializeField]
    float _Speed;
    [SerializeField]
    float _PowerConsumtion;

    public float Modifier { get => _modifier; }
    public EquipmentType EquipmentType { get => _equipmentType;}
    public float CoolDown { get => _coolDown; }
    public float ChargeUp { get => _chargeUp;  }
    public float HeatGenerated { get => _heatGenerated; }
    public float MaxOverClock { get => _maxOverClock; }
    public float Size { get => _size;}
    public float Speed { get => _Speed; set => _Speed = value; }
    public float PowerConsumtion { get => _PowerConsumtion;}


    public static Equipment  NewEquipmentInstance( EquipmentType equipmentType, float modifier, float coolDown, float chargeUp, float heatGenerated, float maxOverclock, float size, float speed, float powerConsumtion)
    {
        Equipment newEquipment = ScriptableObject.CreateInstance<Equipment>();
        newEquipment._equipmentType = equipmentType;
        newEquipment._modifier = modifier;
        newEquipment._coolDown = coolDown;
        newEquipment._chargeUp = chargeUp;
        newEquipment._heatGenerated = heatGenerated;
        newEquipment._maxOverClock = maxOverclock;
        newEquipment._size = size;
        newEquipment._Speed = speed; ;
        newEquipment._PowerConsumtion = powerConsumtion;
        return newEquipment;
    }
}
