using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ControllerCharacter : MonoBehaviour {

    float speedX = 1.0f;
    float time = 8.0f;
    Rigidbody rb;

    void Start() {

       Rigidbody rb = GetComponent<Rigidbody>();
    }

    void Update() {
       
        if(Input.GetKey(KeyCode.A)) {

            transform.position -= (transform.right / time);
        }
        else if(Input.GetKey(KeyCode.D)) {

            transform.position += (transform.right / time);
        }

        if(Input.GetKey(KeyCode.W)) {

            transform.position += (transform.forward / time);
        }
        else if(Input.GetKey(KeyCode.S)) {

            transform.position -= (transform.forward / time);
        }

    }
}