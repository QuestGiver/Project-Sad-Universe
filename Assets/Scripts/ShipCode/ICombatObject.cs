using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ICombatObject//Interface for the objects in a combat scene 
{
    public void UpdatePosition();
    public float ReportInitiative();
    public void ProcessEquipmentEffect(Equipment equipment);
    public void OnDeath();
    public Attributes Attributes { get;}
    public BaseStats Stats { get; }
    public string UniversalName { get; }
    public Equipment ReturnEquipmentOfType(EquipmentType _equipmentType);
    public ICombatObject ImplementUniversalData(UniversalData universalData);
    public ICommanderInfo OwnerID { get; set; }
}



