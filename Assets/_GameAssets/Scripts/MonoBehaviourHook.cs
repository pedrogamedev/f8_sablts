using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourHook : MonoBehaviour
{
    public static MonoBehaviourHook instance;

    private void Awake() {
        if(instance == null) {
            instance = this;
            return;
        }
        Destroy(this);
    }

    void Start()
    {

    }

    private void Update() {
        UpdateManager.Update();
    }
}
