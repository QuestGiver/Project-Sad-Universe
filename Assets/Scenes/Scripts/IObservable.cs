using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObservable
{
    void addObverver();

    void removeObserver();

    void notifyObserver();



}
