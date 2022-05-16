using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
//receives the input commands of the player for processing
public class UiInputManager : MonoBehaviour
{
    public CombatManager combatManager;
    public GameObject EquipementContentView;
    public Button EquipmentButtonPrefab;
    public Slider throttle;
    public Slider CommandBar;
    public Button Weapon;




    // Start is called before the first frame update
    void Start()
    {
        foreach (Equipment item in Ship.Equipment)
        {
            Button newButton = Instantiate(EquipmentButtonPrefab, EquipementContentView.transform);
            newButton.GetComponentInChildren<Text>().text = item.EquipmentName;
            newButton.onClick.AddListener(item.ActivateEquipment);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
