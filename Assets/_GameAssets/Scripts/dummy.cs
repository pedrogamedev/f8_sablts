using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dummy : MonoBehaviour
{
    public EquipmentItemDataSO item;
    public TextMeshProUGUI uitext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y)) {
            uitext.text = System.Guid.NewGuid().ToString();
        }
    }
}