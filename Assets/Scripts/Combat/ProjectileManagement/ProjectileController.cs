using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Projectiles use this class to allow functionality to be shot down/healed/etc. Basically mini ships.
public class ProjectileController
{
    public int Damage;
    HitPoints hitPoints;
    RadarInfo radarInfo;
    public HitPoints HitPoints
    { 
        get => hitPoints;
        set => hitPoints = value;
    }
    public RadarInfo RadarInfo
    {
        get => radarInfo;
        set => radarInfo = value;
    }
}