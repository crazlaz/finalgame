using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MouseMovment : MonoBehaviour {

    private Transform playerBody;
    Rigidbody rigidBody;

    private Vector2 mouse;
    float xRotation = 50f;
    float mouseSpeedXAxis = 50;
    float mouseSpeedYAxis = 50;
    float yRotation = 50f; 


    public float mouseSensitivity = 1; 
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; //makes sure cursor doesnt go everywhere cant go over 90 degress
        yRotation = -Mathf.Clamp(Input.GetAxis("Mouse Y") + mouseSpeedYAxis, -80f, -80f);
        xRotation = Input.GetAxis("Mouse X") * mouseSpeedXAxis;
        playerBody = this.transform.parent.transform;



    }

    // Update is called once per frame
    void Update()
    {
        RotateCamera();
  

    }


    void RotateCamera()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

      

        xRotation -= mouseY;
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        
       
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        playerBody.Rotate(Vector3.up * mouseX);




    }


}

