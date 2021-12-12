using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New PowerPlant Data", menuName = "PowerPlant Data", order = 51)]
public class PowerPlantConfig : ScriptableObject, IShipEquipment
{


    //fields------------------------------
    [SerializeField]
    float heatGenerated = 10;
    [SerializeField]
    float powerSupply = 10;
    [SerializeField]
    float coolDown = 1;//turns before it can be used again. 1 means usable every turn.
    [SerializeField]
    float chargeUp = 1;//delay before it can be used measured in turns. 1 means usuable every turn

    //interface properties--------------
    public float CoolDown { get => coolDown; set => coolDown = value; }
    public float ChargeUp { get => chargeUp; set => chargeUp = value; }
    public float HeatGenerated { get => heatGenerated; set => heatGenerated = value; }

    //properties=====================


    public void ActivateEquipment(IShip _target, IShip _source)
    {
        throw new System.NotImplementedException();//on/off? I guess no power means being harder to detect? resistance to certain debuffs?
    }

    public void ProcessHeat(IShip _source)
    {
        ShipStats temp = _source.ShipStats;
        temp.Heat += HeatGenerated * _source.getActiveModifierUnitValue(_source.returnShip().ActiveEquipmentMod);
        _source.ShipStats = temp;
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
