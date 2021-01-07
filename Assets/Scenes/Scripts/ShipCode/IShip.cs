using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShip
{
    void ShipAttack();
    void UpdatePosition();
    void ShipDestroy();
}

public struct ShipBehaviors
{

}

public struct ShipStats
{
    public int HpMax;
    public int HP;

}
