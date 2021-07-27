using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectedTriggerManager : MonoBehaviour
{

	public string scriptNameToTrigger;	
	
    void OnTriggerStay(Collider playerCol)
    {
    	if(playerCol.tag == "Player")
		{
			var toEnableOrDisable = GetComponent(scriptNameToTrigger) as MonoBehaviour;
			// This looks awful but works and makes sense
			if(playerCol.transform.gameObject.GetComponent<SelectionManager>().objPlayerIsLookingAt == this.gameObject)
			{
				toEnableOrDisable.enabled = true;
			}
			else
			{
				toEnableOrDisable.enabled = false;
			}
		}
    }

	void OnTriggerExit(Collider playerCol)
	{
		if(playerCol.tag == "Player")
		{
			(GetComponent(scriptNameToTrigger) as MonoBehaviour).enabled = false;
		}
	}
}
