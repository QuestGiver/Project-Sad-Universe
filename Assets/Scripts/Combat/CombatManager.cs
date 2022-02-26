using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CombatManager : MonoBehaviour
{
    public TurnOrder turnOrder;
    public RadarManager radarManager;
    public List<EncounterAI> encounterAI = new List<EncounterAI>();
    void Start()
    {

    }

    public void InitializeCommanders()
    {

    }

    public void TurnUpdate()
    {

    }

    void NextShip()
    {

    }

    void Actions()
    {

    }

    void UpdateRador()
    {

    }




    public void EquipmentProcess(CombatPuppet _target, CombatPuppet _source, ShipEquipment _equipment)
    {
        _equipment.ActivateEquipment(_target, _source);
    }







}
