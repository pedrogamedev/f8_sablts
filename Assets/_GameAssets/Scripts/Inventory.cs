using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Inventory : MonoBehaviour
{
    public UnityEvent<ItemDataSO, int> OnItemAdded;
    public UnityEvent<Inventory> OnInventoryChanged;

    public Dictionary<ItemDataSO, int> items = new Dictionary<ItemDataSO, int>();

    public void AddItem(ItemDataSO item) {
        if (items.ContainsKey(item)) {
            items[item] += 1;
        }
        else {
            items.Add(item, 1);
        }

        OnItemAdded?.Invoke(item, items[item]);
        OnInventoryChanged?.Invoke(this);
    }
}