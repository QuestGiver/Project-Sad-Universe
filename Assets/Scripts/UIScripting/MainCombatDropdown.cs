using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//intended to allow the player to switch between different types of equipment
public class MainCombatDropdown : MonoBehaviour
{
    public Dropdown MainCombatDropMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ParseMenuSelection()
    {
        switch(MainCombatDropMenu.value)
        {
            case 0:
                WeaponsMenu();
                break;

            default:

                break;

        }
    }

    public void WeaponsMenu()
    {
        Debug.Log("I am A fucking goomba");
    }
}
