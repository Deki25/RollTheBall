using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathTrigger : MonoBehaviour 
{
	PlayerMovement playerMove;
	public GameObject Player;

	private void Start()
	{
		playerMove = Player.GetComponent<PlayerMovement> ();
	}

	private void OnTriggerEnter(Collider coli)
	{
		if (coli.tag == "Player") 
		{
			playerMove.isDead = true;
		}
	}
}
