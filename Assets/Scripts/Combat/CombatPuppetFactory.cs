using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatPuppetFactory
{
    CombatPuppet vessel = new CombatPuppet();

    public CombatPuppet GenerateShip(ShipTypes _shipType)
    {
        switch (_shipType)
        {
            case ShipTypes.AA:

                break;
            case ShipTypes.AS:

                break;
            case ShipTypes.PD:

                break;
            case ShipTypes.SD:

                break;
            case ShipTypes.TV:

                break;
            case ShipTypes.SV:

                break;
            default:

                break;
        }

        return vessel;
    }




    void GenerateName()
    {
        vessel.ShipName = "Test";
    }
}


