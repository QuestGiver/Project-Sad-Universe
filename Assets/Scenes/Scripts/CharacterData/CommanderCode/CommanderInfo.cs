using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommanderInfo : ScriptableObject
{
    public List<Ship> CommanderFleet = new List<Ship>();
    public string Name;

    public void SubmitFleet()
    {
        if (CommanderFleet.Count > 0)
        {
            
        }
    }


}
