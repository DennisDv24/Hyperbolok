using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooksAtPlayer : MonoBehaviour
{
	
	GameObject player;

    void Start()
    {
		GameObject[] players = GameObject.FindGameObjectsWithTag("Player");
		player = players[0];
    }
	

	float rot;
	void Update()
	{
		rot = Mathf.Atan((gameObject.transform.position.x - player.transform.position.x)
				/(gameObject.transform.position.z - player.transform.position.z));
		transform.rotation = Quaternion.Euler(0, Mathf.Rad2Deg * rot, 0);
	}

}
