using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniversalPuppet : MonoBehaviour
{
    [SerializeField]
    bool isAI = false;
    public Ship model;
    public Slider power;
    public Slider shields;
    public Slider equipment;
    public Slider engines;
    public Slider throttle;
    public RadarScript radarScript;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!isAI)
        {
            model.ActiveEngineMod = engines.value / 10;
            model.ActivePowerMod = power.value;
            model.ActiveEquipmentMod = equipment.value / 10;
            model.ActiveShieldMod = shields.value / 10;
        }

    }

    public void TickTurn()
    {
        //TEST CODE
        radarScript.BlipArenaPosition += model.ShipStats.Speed * throttle.value;
        //TEST CODE
    }
}
