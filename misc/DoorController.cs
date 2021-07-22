using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MilkShake;

public class DoorController : MonoBehaviour
{
	public Shaker playerShaker;
	public ShakePreset shakerPreset;

	Animator doorAnimator;	
	void Start()
	{
		doorAnimator = GetComponent<Animator>();
	}

	void OnTriggerStay(Collider playerCol)
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			doorAnimator.SetBool("UsingDoor", true);
			playerShaker.Shake(shakerPreset);

			//Play opening Sound
		}

		if(doorAnimator.GetCurrentAnimatorStateInfo(0).IsName("OpenDoor") ||
		   doorAnimator.GetCurrentAnimatorStateInfo(0).IsName("CloseDoor"))
			doorAnimator.SetBool("UsingDoor", false);
		
	}

	void OnTriggerExit(Collider playerCol)
	{
		if(playerCol.tag == "Player")	
			doorAnimator.SetBool("UsingDoor", false);
	}


}
