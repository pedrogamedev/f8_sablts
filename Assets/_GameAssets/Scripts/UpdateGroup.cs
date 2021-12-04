using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateGroup
{
    public event Action OnUpdate;

    float updateDelay;
    float updateTimer;

    public UpdateGroup(float delay) {
        updateDelay = delay;
    }

    public void Update() {
        updateTimer += Time.deltaTime;

        if(updateTimer > updateDelay) {
            OnUpdate?.Invoke();
            updateTimer -= updateDelay;
        }
    }
}