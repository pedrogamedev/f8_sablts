using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourHook : MonoBehaviour
{
    public static MonoBehaviourHook instance;

    public GameObject target;
    
    public float updateTimer;

    private void Awake() {
        if(instance == null) {
            instance = this;
            return;
        }
        Destroy(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager.Dummy();
    }

    private void Update() {

    }
}
