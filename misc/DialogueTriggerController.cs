using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerController : MonoBehaviour
{
	
	public string dialogueNameToAdd;
	public GameObject dialoguePrefab;
	GameObject canvas;
	
	void Start()
	{
		canvas = GameObject.FindGameObjectsWithTag("Canvas")[0];
	}

	private void OnTriggerEnter(Collider playerCol)
    {
		if (playerCol.tag.Equals("Player")){
			var thisDialogue = Instantiate(dialoguePrefab, new Vector3(0, 0, 0), Quaternion.identity);
			var dialogueTextObj = thisDialogue.transform.Find("Text");
			//DialogueController dilCon = dialogueTextObj.GetComponent<DialogueController>();
			//dilCon.dialogueFileName = dialogueToAdd;

			dialogueTextObj.GetComponent<DialogueController>().dialogueFileName = dialogueNameToAdd;

			thisDialogue.transform.parent = canvas.transform;
			thisDialogue.transform.localPosition = new Vector3(0,0,0);
			playerCol.gameObject.GetComponent<PlayerController2>().movementIsBlocked = true;
				
		}
	}
}
