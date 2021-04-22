using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponConfig
{
    string WeaponName {
        get;// = "Default";
    }
    float BaseDamageModifier {
        get;// = 1;//1 = 100%
    }
}
