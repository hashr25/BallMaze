using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{
	public float speed;
	public Text countText;
	public Text winText;
	public Text timerText;
	public GameObject winFountains;
	private int count;

	void Start()
	{
		count = 0;
		setCountText ();
		winText.text = "";
		winFountains.SetActive (false);
	}

	void FixedUpdate()
	{
		//if( SystemInfo.deviceType == DeviceType.Desktop )
		//{
			float moveHorizontal = Input.GetAxis ("Horizontal");
			float moveVertical = Input.GetAxis ("Vertical");

			Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

			GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);

			//rigidbody.AddForce(Physics.gravity * rigidbody.mass);
		//}

		//else
		//{
			//float moveHorizontal = Input.acceleration.x;
			//float moveVertical = Input.acceleration.z;

			//Vector3 movement = new Vector3( moveHorizontal, 0.0f, moveVertical );

			//rigidbody.AddForce( movement * speed * Time.deltaTime );
		//}
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "PickUp") 
		{
			other.gameObject.SetActive(false);
			count = count + 1;
			setCountText();
		}
	}

	void setCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count >= 12)
		{
			winText.text = "YOU WON in " + timerText.text + "!";
			winFountains.SetActive(true);
			//Add in timer

		}
	}
}