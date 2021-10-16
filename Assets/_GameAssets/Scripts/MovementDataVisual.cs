using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDataVisual : MonoBehaviour
{
    public MovementDataSO movementData;

    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.color = movementData.color;
    }

    // Update is called once per frame
    void Update()
    {
        sprite.color = movementData.color;
    }
}
