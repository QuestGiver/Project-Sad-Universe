using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * 
 * Developer note, this version of the observer pattern is attributed to the Head First Design Pattterns book byEric freeman & Elisabeth Robson
 * Concept: The two interfaces, "IObservable" and "IObserver" work together to create a Push-Pull system of information transfer.
 * The observable will push a notification to the observer which pulls important data from the observable.
 * Implamentation notes:
 * -A concrete implamentation for the observer needs to somehow have 
 * the concrete implamention for the observable passed to it.
 * -
 * 
 * 
 */

//Observers push the notification 
public interface IObservable
{
    void addObverver(IObserver _spy);

    void removeObserver(IObserver _spy);

    void notifyObserver();

    //implament a list of Observers


}
