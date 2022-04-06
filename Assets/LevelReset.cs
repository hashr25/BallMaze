using UnityEngine;
using System.Collections;

public class LevelReset : MonoBehaviour {

	void Update() {
		if (Input.GetKeyDown("return"))
        {
			Application.LoadLevel("LargeMaze1");
		}
	}

}
