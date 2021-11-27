using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUsable
{
    void Use();
}

[CreateAssetMenu(fileName = "itemData", menuName = "Scriptable Objects/ItemData", order = 2)]
public class ItemDataSO : ScriptableObject, IUsable
{
    public string itemName;
    public Sprite itemIcon;

    public override string ToString() {
        var baseString = base.ToString();
        return $"{baseString}\n{itemName}";
    }

    public virtual void Use() {
        Debug.Log($"{itemName} was used!");
    }
}