using UnityEngine;
using System.Collections;

public class readyGo : MonoBehaviour {

	public float startTime = 2f;
	void Start () {
		StartCoroutine("idlemove");
		Time.timeScale= 0;
	}


	// Update is called once per frame
	void Update () {
	
		startTime -= Time.deltaTime;
		if ( startTime >= 0f ) {

			return;
		}

		Time.timeScale= 1;
	}
}
