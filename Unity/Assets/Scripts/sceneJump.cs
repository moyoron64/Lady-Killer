using UnityEngine;
using System.Collections;

public class sceneJump : MonoBehaviour {
	
	public float startTime = 1f;
	public string goScene;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if ( startTime >= 0f ) {
			startTime -= Time.deltaTime;
			return;
		}
		Application.LoadLevel(goScene);
		
	}
}
