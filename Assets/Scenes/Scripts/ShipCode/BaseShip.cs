using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseShip : MonoBehaviour, IShip
{
    IShipEquipment ShipAttackBehavior;

    public void ShipDestroy()
    {
        throw new System.NotImplementedException();
    }

    public void UpdatePosition()
    {
        throw new System.NotImplementedException();
    }

    public void ShipAttack()
    {
        ShipAttackBehavior.Activate();
    }

    // Start is called before the first frame update
    void Start()
    {
        ShipAttackBehavior = new ShipWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
