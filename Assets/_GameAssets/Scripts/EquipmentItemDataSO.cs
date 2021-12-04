using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "itemData", menuName = "Scriptable Objects/EquipmentItemData", order = 3)]
public class EquipmentItemDataSO : ItemDataSO, IUsable
{
    public float atkPower;

    public override void Use() {
        Debug.Log("Equiped a " + itemName + " with " + atkPower + " atk power");
    }
}