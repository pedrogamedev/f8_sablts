using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "itemData", menuName = "Scriptable Objects/ItemData", order = 2)]
public class ItemDataSO : ScriptableObject
{
    public string itemName;
    public Sprite itemIcon;
}