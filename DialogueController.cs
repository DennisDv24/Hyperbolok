using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Threading;
 using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
	string dialogueRoute = "Assets/Dialogues/";
	public string dialogueFileName;

	string[] lines;
	Text uiText;
	void Start(){
		lines = System.IO.File.ReadAllLines(dialogueRoute + dialogueFileName);

        uiText = gameObject.GetComponent<Text>(); 
	}
	
	int messageShowingNumber = -1; // The flow of the program requires it to start at -1
	[HideInInspector] public bool lastMessageHasBeenShown = true;
	void Update(){

		if((lastMessageHasBeenShown && Input.GetMouseButtonDown(0))|| messageShowingNumber == -1)
		{
			lastMessageHasBeenShown = false;
			messageShowingNumber ++;
			if(messageShowingNumber >= lines.Length){
				Destroy(transform.parent.gameObject);
				GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
				foreach (GameObject player in players)
				{
					player.GetComponent<PlayerController2>().movementIsBlocked = false;
					
				}
			}
			uiText.text = "";
		}
		else if(!lastMessageHasBeenShown)
		{
			ShowMessage(messageShowingNumber);		
		}
	
	}
	
	int i = 0;
	void ShowMessage(int messageNumber)
	{
		if(i >= lines[messageNumber].Length)
		{
			lastMessageHasBeenShown = true;
			i = 0;
		}
		else
		{
			uiText.text += lines[messageNumber][i];
			i++;
		}
	}

}
