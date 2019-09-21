using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObject : MonoBehaviour {

    void Start() {
        
        
    }

    void FixedUpdate() {
        
        Quaternion rotationYy = Quaternion.AngleAxis(1, Vector3.left);
        transform.rotation *= rotationYy;

    }
}
