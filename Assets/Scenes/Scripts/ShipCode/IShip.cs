using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShip
{
    void ShipAttack();
    void UpdatePosition();
    void ShipDestroy();
}

public struct ShipStats
{
    public int HpMax;//aka max structural integrity
    public int HP;//aka current structural integrity
    public int SpeedMax;
    public int Speed;

}
