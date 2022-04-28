using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICombatObject
{
    public void UpdatePosition();
    public void SetOwner(ICommanderInfo _commanderInfo);

    public float ReportInitiative();
    public Attributes Attributes { get;}
    public BaseStats Stats { get; }
    public string UniversalName { get; }
    public Equipment ReturnEquipmentOfType(EquipmentType _equipmentType);
}



