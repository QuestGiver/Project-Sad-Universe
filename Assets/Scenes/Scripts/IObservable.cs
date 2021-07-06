using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable
{
    void addObverver(IObserver _spy);

    void removeObserver(IObserver _spy);

    void notifyObserver();



}
