using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarManager : MonoBehaviour
{
    [SerializeField]
    private GameObject blipPrefab;
    public List<RectTransform> Blips;
    [SerializeField]
    private float blipArenaPosition = 1;
    public float ScreenWidth;
    public float ArenaBounds = 100;//default 100 = 10 lightyears, which means that attacks generally take less than a second to travel to the target at even a fraction of maximum hyperscale. Might be slightly randomized or effected by sensor ranges.

    public float GetBlipArenaPosition()
    {
        return blipArenaPosition;
    }

    public void SetBlipArenaPosition(float value)
    {
        blipArenaPosition = value;
        Vector3 temp = Vector3.zero;
        temp.x = (ScreenWidth * (blipArenaPosition / ArenaBounds));//calculates just how far from the other side of the screen the ships blip is. Acomplished by using position and arena bounds to make a percentage.
        temp.y = Blips[0].position.y;
        temp.z = Blips[0].position.z;
        Blips[0].position = temp;
    }

    void Start()
    {
        ScreenWidth = Screen.width;
        Vector3 temp = Blips[0].position;
        temp.x = ScreenWidth * 0.1f;
        Blips[0].position = temp;
    }

    void Update()
    {
        SetBlipArenaPosition(blipArenaPosition);
    }

    void UpdateOnTurn(ICombatObject _ship)
    {

    }
}
