using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public Dictionary<ItemDataSO, int> items = new Dictionary<ItemDataSO, int>();

    public void AddItem(ItemDataSO item) {
        if (items.ContainsKey(item)) {
            items[item] += 1;
        }
        else {
            items.Add(item, 1);
        }

        foreach (var i in items) {
            Debug.Log(i.Key.name);
        }
    }
}
