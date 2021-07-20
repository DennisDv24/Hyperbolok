using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSpeed = 200f;


    void Start()
    {        
        Cursor.lockState = CursorLockMode.Locked;
    }

    float xRotation, yRotation = 0f;

    public Transform parentTransform;
	void FixedUpdate(){

        float mouseX = Input.GetAxis("Mouse X") * mouseSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSpeed;                
            // xRotation += mouseY because you want to rotate the X axis of the
            // camera with the y axis of the mouse
            xRotation -= mouseY; // -= to invert the control
            yRotation += mouseX;

            // Mathf.Clamp Limits the rotation to not break players neck to 180º
            xRotation = Mathf.Clamp(xRotation, -90f, 90f); 
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        parentTransform.rotation = Quaternion.Euler(0f, yRotation, 0f);
        // The Y rotation should rotate the player body, not the camera,
        // to make the controls work fine. 

	}
    

}
