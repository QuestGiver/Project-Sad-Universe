using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : IObserver
{
    public virtual void oUpdate()
    {
        throw new System.NotImplementedException();
    }
}
