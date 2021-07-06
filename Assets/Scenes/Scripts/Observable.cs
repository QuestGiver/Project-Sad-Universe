using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observable : IObservable
{
    List<IObserver> spies;

    public virtual void addObverver(IObserver _spy)
    {
        spies.Add(_spy);
    }

    public virtual void notifyObserver()
    {
        foreach (IObserver item in spies)
        {
            item.oUpdate();
        }
    }

    public virtual void removeObserver(IObserver _spy)
    {
        spies.Remove(_spy);
    }

    void getState()
    {
        throw new System.NotImplementedException();
    }

    void setState()
    {
        throw new System.NotImplementedException();
    }

}