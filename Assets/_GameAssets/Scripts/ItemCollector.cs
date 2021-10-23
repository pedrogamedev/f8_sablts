using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] KeyCode key;
    [SerializeField] Inventory inventory;
    ItemObj currentItem;

    private void Update() {
        if (Input.GetKeyDown(key) && currentItem) {
            inventory.AddItem(currentItem.itemData);
            Destroy(currentItem.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("item")) {
            currentItem = collision.GetComponent<ItemObj>();
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.CompareTag("item")) {
            currentItem = null;
        }
    }
}