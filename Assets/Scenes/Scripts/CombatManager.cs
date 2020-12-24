using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    private int Round;//Current Round
    private int Turn;//Current turn
    private int Reactions;//number of reactions left to cycle through

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int[] InitializeTurnOrder(int[] _speedStatArray)
    {
        for (int i = 0; i < _speedStatArray.Length; i++)
        {
            if (i + 1 < _speedStatArray.Length)
            {
                if (_speedStatArray[i] > _speedStatArray[i + 1])
                {
                    _speedStatArray[i] += _speedStatArray[i + 1];
                    _speedStatArray[i + 1] -= _speedStatArray[i];
                    _speedStatArray[i] -= _speedStatArray[i + 1];
                    i = 0;
                }
            }
        }

        return _speedStatArray;
    }

    private void TurnManager()//should be a coroutine
    {

    }

    private void RoundManager()//should be a coroutine
    {

    }

    private void ReactionCounter()//should be a coroutine
    {
        //event logic
    }

}
