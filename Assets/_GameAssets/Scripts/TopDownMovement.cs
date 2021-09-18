using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    public MovementData movementData;
    Vector2 dir;
    Rigidbody2D rb;
    IController controller;

    private void Start() {
        Debug.Log("Start on " + gameObject.name);
        rb = GetComponent<Rigidbody2D>();        
        RefreshController();
    }

    void Update()
    {
        rb.velocity = dir.normalized * movementData.speed;
    }

    public void RefreshController() {
        dir = Vector2.zero;

        if (TryGetComponent(out controller)) {
            controller.OnDirectionInput += (new_dir) => {
                dir = new_dir;
            };
        }
        else {
            Debug.LogWarning("No Controller");
        }
    }
}
