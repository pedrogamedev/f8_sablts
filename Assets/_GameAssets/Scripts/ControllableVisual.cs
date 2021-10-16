using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controllable))]
public class ControllableVisual : MonoBehaviour
{
    [SerializeField] ParticleSystem effect;

    Controllable controllable;
    bool playing;

    private void Start() {
        controllable = GetComponent<Controllable>();
    }

    // Update is called once per frame
    void Update()
    {
        if(controllable.Ready && !playing) {
            effect.Play();
            playing = true;
        }
        else if(!controllable.Ready) {
            effect.Stop();
            playing = false;
        }
    }
}
