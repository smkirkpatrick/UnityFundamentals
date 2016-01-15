using UnityEngine;
using System.Collections;

public class ObjectColor : MonoBehaviour
{
	public Color changedColor = Color.white;
	Color originalColor = Color.white;
	[HideInInspector][SerializeField] new Renderer renderer;

	void Awake()
	{
		renderer = GetComponent<MeshRenderer>();
		originalColor = renderer.material.color;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.G)) {
			EnableColor();
		}
		else if (Input.GetKeyUp(KeyCode.G)) {
			DisableColor();
		}
	}

	public void EnableColor()
	{
		renderer.material.color = changedColor;
	}

	public void DisableColor()
	{
		renderer.material.color = originalColor;
	}
}
