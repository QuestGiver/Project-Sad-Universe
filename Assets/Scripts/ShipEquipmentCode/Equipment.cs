using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Item", menuName = "ScriptableObjects/ShipEquipment", order = 1)]
public abstract class Equipment : ScriptableObject
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
