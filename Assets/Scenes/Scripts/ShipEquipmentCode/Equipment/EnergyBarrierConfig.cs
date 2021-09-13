using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New EnergyBarrier Data", menuName = "EnergyBarrier Data", order = 51)]
public class EnergyBarrierConfig : ScriptableObject, IShipEquipment
{

    //fields------------------------------
    [SerializeField]
    float barrierMultiplier;
    [SerializeField]
    float coolDown = 1;//turns before it can be used again. 1 means usable every turn.
    [SerializeField]
    float chargeUp = 1;//delay before it can be used measured in turns. 1 means usuable every turn
    [SerializeField]
    float heatGenerated = 10;

    //interface properties--------------
    public float CoolDown { get => coolDown; set => coolDown = value; }
    public float ChargeUp { get => chargeUp; set => chargeUp = value; }
    public float HeatGenerated { get => heatGenerated; set => heatGenerated = value; }

    //properties=====================

    public void Activate(IShip _target, IShip _source)
    {
        throw new System.NotImplementedException();
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
