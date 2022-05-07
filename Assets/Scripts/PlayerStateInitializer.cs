using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateInitializer : MonoBehaviour
{
    public List<UniversalData> savedPlayerFleet =  new List<UniversalData>();
    // Start is called before the first frame update
    void Awake()
    {
        PlayerState.fleet = savedPlayerFleet;
    }
}
