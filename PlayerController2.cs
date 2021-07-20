using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    public float movementSpeed = 10f;
	public bool movementIsBlocked = false;
	void FixedUpdate(){
		if(!movementIsBlocked){
			float xPos = Input.GetAxis("Horizontal"); // To move right
			float zPos = Input.GetAxis("Vertical"); // To move forwars

			Vector3 difPosition = transform.right * xPos + transform.forward * zPos; 

			transform.localPosition += difPosition * movementSpeed;
		}

		
	}
}
