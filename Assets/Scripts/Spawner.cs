using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public GameObject spawnType = null;

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space)) {
			GameObject obj = Instantiate ( spawnType ) as GameObject;
			obj.transform.position = this.transform.position;
			obj.AddComponent<Rigidbody>();
			obj.name = "mySphere";
		}
	}
}
