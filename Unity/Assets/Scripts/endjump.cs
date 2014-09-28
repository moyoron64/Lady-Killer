








using UnityEngine;
using System.Collections;

public class endjump : MonoBehaviour {
	
	
	public float startTime = 5;
	
	void Start () {
		
		
	}
	
	
	// Update is called once per frame
	void Update () {
		
		if ( startTime >= 0f ) {
			startTime -= Time.deltaTime;
			return;
		}
		
		
		Application.LoadLevel("rogo");
		
	}
}



