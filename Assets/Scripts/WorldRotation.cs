using UnityEngine;
using System.Collections;

public class WorldRotation : MonoBehaviour 
{
	// Update is called once per frame
	public float smooth;
	public float tiltAngle;

	// This movement functionality was derived from the "Roll A Ball" tutorial on Unity3D.com

	//This Function is for PC control
	void Update() 
	{
		float tiltAroundZ = -Input.GetAxis("Horizontal") * tiltAngle;
		float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
		Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
	}

	//This Function is for iOS and Android control
	/*void Update()
	{
		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.z = Input.acceleration.z;
		//dir.y = Input.acceleration.y;
		Physics.gravity = dir * 20;*/

		//float tiltAroundZ = -Input.acceleration.x * tiltAngle;
		//float tiltAroundX = Input.acceleration.z * tiltAngle;
		//Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
		//transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
		//transform.
	//}
}