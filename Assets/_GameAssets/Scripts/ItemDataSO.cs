using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUsable
{
    void UseItem();
}

[CreateAssetMenu(fileName = "itemData", menuName = "Scriptable Objects/ItemData", order = 2)]
public class ItemDataSO : ScriptableObject, IUsable
{
    public string itemName;
    public Sprite itemIcon;

    public void UseItem() {

    }
}