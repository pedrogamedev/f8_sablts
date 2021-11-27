using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemIcon : MonoBehaviour
{
    [SerializeField] Image icon;
    [SerializeField] TextMeshProUGUI count;
    IUsable item;

    public void SetData(ItemDataSO itemData, int qnt) {
        item = itemData;
        icon.sprite = itemData.itemIcon;
        count.text = qnt.ToString();
        count.gameObject.SetActive(true);
    }

    public void ItemClicked() {
        item.UseItem();
    }
}


