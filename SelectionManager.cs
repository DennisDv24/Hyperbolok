using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
	public Camera playerCamera;
	//[HideInInspector] 
	public GameObject objPlayerIsLookingAt;

		// To make raycasts ignore triggers go to
		// Edit > Project Settings > Physics > Uncheck "Queries Hit Triggers"
    void Update()
    {
		
		Vector3 mousePosition = new Vector3(Screen.width/2f, Screen.height/2f, 0f);
    	var ray = playerCamera.ScreenPointToRay(mousePosition); 
		RaycastHit rayHit;
		if(Physics.Raycast(ray, out rayHit)) // It detects objects with colliders
		{
			objPlayerIsLookingAt = rayHit.transform.gameObject; 
		}
    }

}
