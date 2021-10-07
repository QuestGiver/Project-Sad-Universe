using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommanderShell : MonoBehaviour
{
    public CommanderInfo commanderInfo;
    public CombatManager combatManager;

    // Start is called before the first frame update
    void Start()
    {
        commanderInfo.SubmitFleet(combatManager);
    }
}
