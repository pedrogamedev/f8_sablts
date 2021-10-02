using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controllable))]
public class ControllableVisual : MonoBehaviour
{
    [SerializeField] ParticleSystem effect;

    Controllable controllable;

    private void Start() {
        controllable = GetComponent<Controllable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controllable.Ready) {
            effect.Play();
        }
        else {
            effect.Stop();
        }
    }
}
