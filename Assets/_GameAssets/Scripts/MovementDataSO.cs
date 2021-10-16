using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "movementData", menuName = "Scriptable Objects/MovementData", order = 1)]
public class MovementDataSO : ScriptableObject
{
    public float speed;
    public Color color;
}
