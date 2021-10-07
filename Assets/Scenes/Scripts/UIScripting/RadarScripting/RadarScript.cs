using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarScript : MonoBehaviour
{
    public CommanderShell Commander;
    public RectTransform blip;
    [SerializeField]
    private float blipArenaPosition = 1;
    public float ScreenWidth;
    public float ArenaBounds = 100;//default 100 = 10 lightyears, which means that attacks generally take less than a second to travel to the target at even a fraction of maximum hyperscale. Might be slightly randomized or effected by sensor ranges.

    public float BlipArenaPosition
    {
        get
        {
           return blipArenaPosition;
        }
        set
        {
            blipArenaPosition = value;
            Vector3 temp = Vector3.zero;
            temp.x = (ScreenWidth * (blipArenaPosition/ArenaBounds));
            temp.y = blip.position.y;
            temp.z = blip.position.z;
            blip.position = temp;
        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        Vector3 temp = blip.position;
        temp.x = ScreenWidth * 0.1f;
        blip.position = temp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateOnTurn(IShip _ship)
    {
        //update ship pos
    }
}
