using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ICombatObject//Interface for the objects in a combat scene 
{
    public void UpdatePosition();
    public void ProcessEquipmentEffect(Equipment equipment);
    public Attributes Attributes { get;}
    public BaseStats Stats { get; }
    public string UniversalName { get; }
}



