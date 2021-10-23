using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryListVisual : MonoBehaviour
{
    [SerializeField] Inventory inventory;
    [SerializeField] TextMeshProUGUI list;

    void Update() {
        list.text = "";

        foreach (var item in inventory.items) {
            list.text += item.Key.itemName + " x" + item.Value + "\n" ;
        }
    }
}
