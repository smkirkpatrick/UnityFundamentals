using UnityEngine;
using System.Collections;

public class TriggerEvent : MonoBehaviour
{
	public GameObject lightBulb = null;
	public GameObject wall = null;
	public AudioClip lightBulbOn = null;

	void OnTriggerEnter ( Collider other )
	{
		if (other.name == "player") {
			// turn on the light
			lightBulb.SetActive(true);

			AudioSource audioSource = GetComponent<AudioSource>();

			Debug.Log( "blend: " + audioSource.spatialBlend + ", max distance: " + 
						audioSource.maxDistance);
			//GetComponent<AudioSource>().PlayOneShot( lightBulbOn );
			audioSource.clip = lightBulbOn;
			audioSource.Play();

			// wall.EnableScale();
			wall.GetComponent<ObjectScaling>().EnableScale();
			wall.GetComponent<ObjectColor>().EnableColor();
		}
	}

	void OnTriggerExit ( Collider other )
	{
		if (other.name == "player") {
			lightBulb.SetActive(false);
			GetComponent<AudioSource>().Stop();
			wall.GetComponent<ObjectScaling>().DisableScale();
			wall.GetComponent<ObjectColor>().DisableColor();
		}
	}
}
