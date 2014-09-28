using UnityEngine;
using System.Collections;

public class prolougeJump : MonoBehaviour {
	
	
	public float startTime = 21f;
	private string goScene;
	// Use this for initialization
	void Start () {
		
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		Touch touch = Input.GetTouch (0);
		
		// ゲーム中ではなく、タッチ直後であればtrueを返す。
		if (touch.phase == TouchPhase.Began) {
			
			result(Application.loadedLevelName);
			
		}


		if ( startTime >= 0f ) {
			startTime -= Time.deltaTime;
			return;
		}
		
		result(Application.loadedLevelName);



		
		
	}
	
	void result(string sceneName){
		
		switch(sceneName) {
		case "Prologue1":
			goScene = "Scene1";
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
