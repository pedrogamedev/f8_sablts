using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "itemData", menuName = "Scriptable Objects/EquipmentItemData", order = 3)]
public class EquipmentItemDataSO : ItemDataSO, IUsable
{
    public float atkPower;

    public override string ToString() {
        var baseStringEquip = base.ToString();
        return $"{baseStringEquip}\n{itemName}:{atkPower}";
    }

    public override void Use() {
        base.Use();
        Debug.Log("Equiped a " + itemName + " with " + atkPower + " atk power");
    }
}