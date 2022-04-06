using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public GameObject player;
	public Vector3 offset;

	public float zoomSpeed = 1;
	private float currentZoom = 0;
	private float maxZoom = 35.0f;
	private float minZoom = 3.5f;
	// Use this for initialization
	void Start () 
	{
		offset = transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		if (Input.GetKey("-") && offset.y < maxZoom)
		{
			float zoomAmount = Time.deltaTime * zoomSpeed;
			currentZoom -= zoomAmount;
			offset.y += zoomAmount;
			offset.z -= zoomAmount;
		}
		if (Input.GetKey("=") && offset.y > minZoom)
		{
			float zoomAmount = Time.deltaTime * zoomSpeed;
			currentZoom += zoomAmount;
			offset.y -= zoomAmount;
			offset.z += zoomAmount;
		}

		transform.position = player.transform.position + offset;
	}
}
