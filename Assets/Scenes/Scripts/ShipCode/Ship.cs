using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Ship Data", menuName = "Ship Data", order = 51)]
public class Ship : ScriptableObject, IShip
{




    //Lists===============================================================================================================================|
    //All Equipment is stored here

    public List<WeaponConfig> weaponConfigs = new List<WeaponConfig>();
    //powerplant list
    //engines list
    //etc. Implement when ready

    //Fields==============================================================================================================================|
    [SerializeField]
    private ShipStats shipStats;
    [SerializeField]
    private ShipAttributes shipAttributes;
    //Read_Only Fields----------------------------------------------------------------------------------------------------------------------------------------------|
    [SerializeField]
    private  float multi_Size,//multipliers for the ship, allowing every ship to have strengths and weaknesses
    multi_Engines,
    multi_HeatManagement,
    multi_Structure,
    multi_Affinity,
    multi_AI,
    multi_ArmorRating;
    [SerializeField]
    private float baseDamage = 20; //the base damage that any ship weapon would deal given a damage multiplier of 100%
    [SerializeField]
    private string shipName = "Default";

    //Properties==========================================================================================================================|
    public ShipStats ShipStats { get => shipStats; set => shipStats = value; }
    public ShipAttributes ShipAttributes { get => shipAttributes; set => shipAttributes = value; }
    public float BaseDamage { get => baseDamage;}
    public string ShipName { get => shipName;}
    public float Multi_Size { get => multi_Size;}
    public float Multi_Engines { get => multi_Engines;}
    public float Multi_HeatManagement { get => multi_HeatManagement;}
    public float Multi_Structure { get => multi_Structure;}
    public float Multi_Affinity { get => multi_Affinity;}
    public float Multi_AI { get => multi_AI;}
    public float Multi_ArmorRating { get => multi_ArmorRating;}

    //Methods============================================================================================================================|
    //execute ship destruction behavior
    public void ShipDestroy()
    {
        throw new System.NotImplementedException();
    }

    //DEPRICATE //update ship position on radar
    public void UpdatePosition()
    {
        throw new System.NotImplementedException();
    }

    //check power distibution and update relevant statistics
    public void CheckPowerDist()
    {
        throw new System.NotImplementedException();
    }

    //Takes ship attribute data and turns it into stats to be displayed in combat
    public void AttributesToStats()
    {
        ShipStats statsTemp = shipStats;
        ShipAttributes attributesTemp = shipAttributes;

        //it should be noted that equipment, such as shield generators, have a multiplier that are applied to the following values for a final displayed value.
        //it should also be noted that you should never hard code values if you can help it. Some of the constant values will be replaced in the future.
        shipStats.MaxHp = (10 * shipAttributes.Structure)//this portion multiplies the base stat by ten, simply to make hp feel bigger
                             * ((Multi_Structure*0.75f) + (Multi_Size*0.5f));//the native multipliers on the shipitself are combined to create a conjoined multiplier

        shipStats.MaxHeat = (3 * (shipAttributes.HeatManagement + (0.1f * shipAttributes.Size)))//add a portion of the current size score to the heat management score before inflating the resulting value
                             * (Multi_HeatManagement + (Multi_Size * 0.5f));//applies a combined heatmanagement and size multiplier to the first result

        shipStats.MaxCharge = 10//end result needed to be larger, multiplied entire result by 10
                              * ((0.75f * shipAttributes.AI) + (0.25f * shipAttributes.HeatManagement))//relevant attributes are combined in a 3:1 ratio
                              * ((Multi_AI * 0.75f) + (Multi_HeatManagement * 0.25f));//relevant multiplier are combined in a 3:1 ratio and multiply the current combined attribute value

        shipStats.MaxDissipation = (shipAttributes.HeatManagement * (Multi_HeatManagement * 0.5f))//multiplies the heatmanagement attribute score by a portion of the native heatmanagemnt multiplier
                                   / Mathf.Min(1.5f, shipAttributes.Size / (shipAttributes.HeatManagement * 0.9f));//divides the first value from the above line by
                                                                                                                   //the number of times the ship size att score can fit into a portion of the heat management score. Minimum 1.5.

        shipStats.MaxLuck = ((shipAttributes.Affinity * 0.5f) + (ShipAttributes.AI * 0.5f)) // att scores combined
                            * ((Multi_AI * 0.5f) + (Multi_Affinity * 0.5f));//native multipliers combined to multiply the combined att score

        shipStats.MaxSpeed = (shipAttributes.Engines * Multi_Engines)//directly multiplys the engine att score by the ship-native multiplier
                             / Mathf.Min(1, shipAttributes.Size / shipAttributes.Engines); //divides the first value by the number of times the size score fits into the engines score. Minimum 1.

        shipStats.MaxResistance = (shipAttributes.ArmorRating * Multi_ArmorRating) //multiplied the armor rating score by the native ship multiplier for armor rating directly
                                  * 0.25f;//only use 25% of the value. Get riggidy riggity wrecked.

        shipStats.MaxShield = 10//inflation value
                              * (((shipAttributes.Affinity * 0.5f) + (shipAttributes.AI * 0.5f)) * ((Multi_AI * 0.5f) + (Multi_Affinity * 0.5f)))//three att scores are combined in an even ratio but each value is halved
                              / Mathf.Min(2, (shipAttributes.Size * 0.75f) / shipAttributes.AI);//divides the combined att value by the number of times a portion of the size att can fit into the AI att.

        shipStats.MaxPwrSupply = ((shipAttributes.Affinity * 0.5f) + (shipAttributes.AI * 0.5f)) // half of both the affinity and AI att scores are combined
                                 * ((Multi_Affinity * 0.5f) + (Multi_AI * 0.5f));//a portion of the relevent multipliers are combined to one multiplier

        shipStats.MaxEvasion = ((shipAttributes.Engines) - Mathf.Min(shipAttributes.Engines - 1, (shipAttributes.Size * 0.25f)))//subtracts a quarter of the ship size from the engines att. Minimum is engines att -1.
                               * ((Multi_Engines) - (Multi_Size * 0.25f));// subtracts a quarter of the size native multiplier from the engines multiplier.


        shipStats.HP = shipStats.MaxHp;
        shipStats.Heat = shipStats.MaxHeat;
        shipStats.Charge = shipStats.MaxCharge;
        shipStats.Dissipation = shipStats.MaxDissipation;
        shipStats.Luck = shipStats.MaxLuck;
        shipStats.Speed = shipStats.MaxSpeed;
        shipStats.Resistance = shipStats.MaxResistance;
        shipStats.Shields = shipStats.MaxShield;
        shipStats.PwrSupply  =  shipStats.MaxPwrSupply;
        shipStats.Evasion = shipStats.MaxEvasion;
    }

    private void OnValidate()
    {
        AttributesToStats();
    }

    public Ship()//default creation
    {
        shipName = "Default";
       // ShipAttackBehaviors.Add(new ShipWeapon());
        shipStats = new ShipStats
            (
            100,//hp max
            100,//hp
            100,//speedMax
            100,//speed
            100,//chargeMax
            100,//charge
            100,//evasionMax
            100,//evasion
            100,//dissipationMax
            100,//dissipation
            100,//luckMax
            100,//luck
            100,//resistanceMax
            100,//resistance
            100,//heatMax
            100,//heat
            100,//shieldMax
            100,//shields
            100,//pwrSupplyMax
            100 //pwrSupply
            );

    }

    public Ship(string _shipName, int _baseDamage, ShipStats _shipStats) //specific creation
    {
        shipName = _shipName;
        ShipStats = _shipStats;
        baseDamage = _baseDamage;
    }
}
