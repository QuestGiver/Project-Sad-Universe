using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPuppetFactory
{
    public static CombatPuppet GenerateShip()
    {
        CombatPuppet vessel = new CombatPuppet();
        return vessel;
    }
}


