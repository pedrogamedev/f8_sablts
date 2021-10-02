using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//FOOBAR
public class Controllable : MonoBehaviour
{
    public static GameObject current;

    [SerializeField] bool ready;

    public bool Ready {
        get; private set;
    }

    private void Start() {
        KeyboardController kcontrol;

        if(TryGetComponent(out kcontrol)) {
            current = gameObject;
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            GetComponent<TopDownMovement>().enabled = true;
        }
        else {
            GetComponent<CircleCollider2D>().enabled = true;
            GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            GetComponent<TopDownMovement>().enabled = false;
        }
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space) && ready) {
            if(current != gameObject) {
                Debug.Log("Changing control from: " + current.name + " to: " + gameObject.name);

                Destroy(current.GetComponent<KeyboardController>());
                current.GetComponent<CircleCollider2D>().enabled = true;
                current.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                current.GetComponent<TopDownMovement>().RefreshController();
                current.GetComponent<TopDownMovement>().enabled = false;

                gameObject.AddComponent<KeyboardController>();
                GetComponent<CircleCollider2D>().enabled = false;
                GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                GetComponent<TopDownMovement>().enabled = true;
                GetComponent<TopDownMovement>().RefreshController();

                current = gameObject;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject == current) {
            ready = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject == current) {
            ready = false;
        }
    }
}
