using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonFocusController : MonoBehaviour
{
	public ShowingImageController showingController;
	public HidingImageController hidingController;
	
	public void enableShowing()
	{
		showingController.enabled = true;
	}
	public void disableShowing()
	{
		showingController.enabled = false;
	}
	public void enableHiding()
	{
		hidingController.enabled = true;
	}
	public void disableHiding()
	{
		hidingController.enabled = false;
	}




}
