using UnityEngine;
using System.Collections;

public class prolougeJump : MonoBehaviour {
	
	
	public float startTime;
	public float goTime;
	private string goScene;
	Touch touch;
	// Use this for initialization
	void Start () {

		goTime = startTime;
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		touch = Input.GetTouch (0);
		
		// ゲーム中ではなく、タッチ直後であればtrueを返す。

		if (touch.phase == TouchPhase.Began) {
			
			result(Application.loadedLevelName);
			
		}


		if ( goTime >= 0f ) {
			goTime -= Time.deltaTime;
			return;
		}


		result(Application.loadedLevelName);



		
		
	}
	
	void result(string sceneName){
		
		switch(sceneName) {
		case "Prologue1":
			goScene = "Tutlial";
			break;
		case "Prologue2":
			goScene = "Scene3";
			break;
		case "Prologue3":
			goScene = "Scene5";
			break;
		case "Prologue4":
			goScene = "Scene7";
			break;
		
		}
		
		
		
		
		Application.LoadLevel(goScene);
	}
}
