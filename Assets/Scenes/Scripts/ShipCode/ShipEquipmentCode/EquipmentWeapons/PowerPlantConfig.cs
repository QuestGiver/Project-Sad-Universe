using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPlantConfig : ScriptableObject, IShipEquipment
{


    //fields------------------------------
    float powerSupply = 10;


    //interface properties--------------
    public float CoolDown { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    public float ChargeUp { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    //properties=====================


    public void Activate(IShip _target, IShip _source)
    {
        throw new System.NotImplementedException();//on/off? I guess no power means being harder to detect? resistance to certain debuffs?
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
