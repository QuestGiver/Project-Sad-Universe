using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShipAttributes
{
    [SerializeField]
    private float size,//(total space for upgrades/weapons and size class of ship/this stat and the shield generator rating and slot size determine max shield strength)
    engines,
    heatManagement,
    structure,
    affinity,
    aI,
    armorRating;

    public float Engines { get => engines; set => engines = value; }
    public float HeatManagement { get => heatManagement; set => heatManagement = value; }
    public float Structure { get => structure; set => structure = value; }
    public float Affinity { get => affinity; set => affinity = value; }
    public float AI { get => aI; set => aI = value; }
    public float ArmorRating { get => armorRating; set => armorRating = value; }
    public float Size { get => size; set => size = value; }

    public ShipAttributes(
        float _engines,
        float _heatManagement,
        float _structure,
        float _affinity,
        float _aI,
        float _armorRating,
        float _size
        )
    {
        engines = _engines;//(evasion and speed)
        heatManagement = _heatManagement;//(heat management)
        structure = _structure;//(hit points)
        affinity = _affinity;//(Boarding Defense/how familiar the crew is with the ship and buff/debuff multiplier)
        aI = _aI;//(Luck and misc determinants)
        armorRating = _armorRating;//(Resistance to damage)
        size = _size;//(total space for upgrades/weapons and size class of ship/this stat and the shield generator rating and slot size determine max shield strength)

    }


}