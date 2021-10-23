using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarScript : MonoBehaviour
{
    public List<CommanderShell> Commander;
    public List<RectTransform> Blip;
    Dictionary<CommanderShell,RectTransform> radarCollection= new Dictionary<CommanderShell,RectTransform>();
    [SerializeField]
    private GameObject blipPrefab;
    [SerializeField]
    private float blipArenaPosition = 1;
    public float ScreenWidth;
    public float ArenaBounds = 100;//default 100 = 10 lightyears, which means that attacks generally take less than a second to travel to the target at even a fraction of maximum hyperscale. Might be slightly randomized or effected by sensor ranges.

    public float GetBlipArenaPosition()
    {
        return blipArenaPosition;
    }

    public void SetBlipArenaPosition(float value, CommanderShell shell)//---if a commander shell is not tied to a blip, a new prefab will be instantiated and assigned to it---
    {
        blipArenaPosition = value;
        Vector3 temp = Vector3.zero;
        temp.x = (ScreenWidth * (blipArenaPosition / ArenaBounds));//calculates just how far from the other side of the screen the ships blip is. Acomplished by using position and arena bounds to make a percentage.
        temp.y = Blip[0].position.y;
        temp.z = Blip[0].position.z;
        Blip[0].position = temp;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScreenWidth = Screen.width;
        Vector3 temp = Blip[0].position;
        temp.x = ScreenWidth * 0.1f;
        Blip[0].position = temp;
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
