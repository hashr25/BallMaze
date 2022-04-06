using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text ThisTimer;

	public float timerTime;

	// Use this for initialization
	void Start () 
	{
		timerTime = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timerTime += Time.deltaTime;
		
		DisplayTime(timerTime);

		if (Input.GetKeyDown("return"))
		{
			timerTime = 0;
		}
	}

	void DisplayTime(float timeToDisplay)
	{
		float minutes = Mathf.FloorToInt(timeToDisplay / 60);
		float seconds = Mathf.FloorToInt(timeToDisplay % 60);
		float milliSeconds = (timeToDisplay % 1) * 1000;
		ThisTimer.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
	}
}
