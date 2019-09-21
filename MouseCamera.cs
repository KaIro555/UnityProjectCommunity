using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour {
    private float sensitivityX = 3.0f, sensitivityY = 3.0f;
       
    private float minX = -360.0f, maxX = 360.0f;
    private float minY = -60.0f, maxY = 90.0f;

    private Quaternion originalRot;
    private float rotX, rotY; 
    
    void Start() {

        Rigidbody rb = GetComponent<Rigidbody>();

        if(rb) {
            rb.freezeRotation = true;
        }

        originalRot = transform.localRotation;

    }

    void FixedUpdate() {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
        if(Input.GetKey(KeyCode.Escape)) {

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
        
    void Update() {

        rotX += Input.GetAxis("Mouse X") * sensitivityX;
        rotY += Input.GetAxis("Mouse Y") * sensitivityY;

        //rotX = Mathf.Clamp(rotX, minX, maxX); //оставить если нужно ограничить вращение по оси-X 
        rotY = Mathf.Clamp(rotY, minY, maxY);
    
        Quaternion xQuaternion = Quaternion.AngleAxis(rotX, Vector3.up);
        Quaternion yQuaternion = Quaternion.AngleAxis(rotY, Vector3.left);

        transform.localRotation = originalRot * xQuaternion * yQuaternion;

    }
}