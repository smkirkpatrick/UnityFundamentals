using UnityEngine;
using System.Collections;

public class Cameras : MonoBehaviour
{
	public Transform player = null;

	void LateUpdate ()
	{ 	// ^ Happens after Update() in the game loop
		this.transform.LookAt (player.position);
	}
}
