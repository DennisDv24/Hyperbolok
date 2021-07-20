using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguetriggerController : MonoBehaviour
{
	
	public GameObject dialogueToAdd;
	public GameObject dialogueCanvas;
	
	private void OnTriggerEnter(Collider col)
    {
		if (col.tag.Equals("Player")){
			var thisDialogue = Instantiate(dialogueToAdd, new Vector3(0, 0, 0), Quaternion.identity);
			
			thisDialogue.transform.parent = dialogueCanvas.transform;
			thisDialogue.transform.localPosition = new Vector3(0,0,0);
			col.gameObject.GetComponent<PlayerController2>().movementIsBlocked = false;
				
		}
	}
}
