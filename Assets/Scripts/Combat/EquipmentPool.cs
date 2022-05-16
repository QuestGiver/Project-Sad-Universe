using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the pool of loaded equipment scriptable objects for easy reference
public class EquipmentPool : MonoBehaviour
{
    public static List<ScriptableWeapon> WeaponsPool = new List<ScriptableWeapon>();
}
