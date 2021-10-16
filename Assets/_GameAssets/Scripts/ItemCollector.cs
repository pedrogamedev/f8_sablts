using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    public Inventory inventory;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("item")) {
            var item = collision.GetComponent<ItemObj>().itemData;
            inventory.AddItem(item);
            Destroy(collision.gameObject);
        }
    }
}