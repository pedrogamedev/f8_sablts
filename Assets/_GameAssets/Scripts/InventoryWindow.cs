using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] GameObject itemPrefab;
    [SerializeField] Transform Grid;
    [SerializeField] CanvasGroup canvas;
    bool isVisible;

    private void Start() {
        HideWindow();
    }

    public void UpdateGrid(Inventory inventory) {
        foreach(Transform child in Grid) {
            Destroy(child.gameObject);
        }

        foreach (var item in inventory.items) {
            var newitem = Instantiate(itemPrefab, Grid);
            newitem.GetComponent<ItemIcon>().SetData(item.Key, item.Value);
        }
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Tab)) {
            if(isVisible) {
                HideWindow();
                return;
            }
            ShowWindow();
        }
    }

    public void ShowWindow() {
        canvas.alpha = 1;
        isVisible = true;
    }

    public void HideWindow() {
        canvas.alpha = 0;
        isVisible = false;
    }
}