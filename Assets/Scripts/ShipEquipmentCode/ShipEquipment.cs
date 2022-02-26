using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ShipEquipment : ScriptableObject
{
    public abstract void ActivateEquipment(CombatPuppet _target, CombatPuppet _source);
    public abstract void ProcessHeat(CombatPuppet _source);

    public readonly float Modifier;
    public readonly EquipmentType equipmentType;
    public readonly float CoolDown;
    public readonly float ChargeUp;
    public readonly float HeatGenerated;
    public readonly float MaxOverClock;
}
