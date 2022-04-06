using UnityEngine;
using System.Collections;

public class AccelerometerTilt : MonoBehaviour {
	private Quaternion localRotation; // 
	public float speed = 1.0f; // ajustable speed from Inspector in Unity editor
	
	// Use this for initialization
	void Start () 
	{
		// copy the rotation of the object itself into a buffer
		localRotation = transform.rotation;
	}
	
	
	void Update() // runs 60 fps or so
	{
		// find speed based on delta
		float curSpeed = Time.deltaTime * speed;
		
		// first update the current rotation angles with input from acceleration axis
		localRotation.z += Input.acceleration.x * curSpeed * (float)0.15;
		localRotation.x += -Input.acceleration.z * curSpeed  * (float)0.15;
		
		// then rotate this object accordingly to the new angle
		transform.rotation = localRotation;
	}

}
