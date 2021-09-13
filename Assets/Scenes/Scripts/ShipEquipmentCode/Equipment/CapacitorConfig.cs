using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "new CapacitorConfig data", menuName = "CapacitorConfig data", order = 51)]
public class CapacitorConfig : ScriptableObject, IShipEquipment
{

    //fields------------------------------
    [SerializeField]
    float heatGenerated = 10;
    [SerializeField]
    float coolDown = 1;//turns before it can be used again. 1 means usable every turn.
    [SerializeField]
    float chargeUp = 1;//delay before it can be used measured in turns. 1 means usuable every turn
    [SerializeField]
    string equipmentName = "Default";
    [SerializeField]
    float maxChargeMuliplier;

    //interface properties--------------}
    public string EquipmentName
    {
        get => equipmentName;
        private set => equipmentName = value;
    }
    
    //properties=====================
    public float CoolDown { get => coolDown; set => coolDown = value; }
    public float ChargeUp { get => chargeUp; set => chargeUp = value; }
    public float HeatGenerated { get => heatGenerated; set => heatGenerated = value; }
    public float MaxChargeMuliplier { get => maxChargeMuliplier; set => maxChargeMuliplier = value; }

    //Interface functions============
    //This is the main function of this equipment type
    public void Activate(IShip _target, IShip _source)
    {

    }

    public void HeatHandler(IShip _source)
    {
        ShipStats temp = _source.ShipStats;
       temp.Heat += HeatGenerated * _source.activeModUnitComponent(_source.returnShip().ActiveEquipmentMod);
        _source.ShipStats = temp;
    }
}