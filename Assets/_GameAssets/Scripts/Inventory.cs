using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemDataSO> items = new List<ItemDataSO>();

    public void AddItem(ItemDataSO item) {
        items.Add(item);

        foreach (var i in items) {
            Debug.Log(i.name);
        }
    }
}
