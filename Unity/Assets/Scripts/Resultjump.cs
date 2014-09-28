using UnityEngine;
using System.Collections;

public class Resultjump : MonoBehaviour {


	public float startTime = 4f;
	private string goScene;
	// Use this for initialization
	void Start () {



	
	}
	
	// Update is called once per frame
	void Update () {

		if ( startTime >= 0f ) {
			startTime -= Time.deltaTime;
			return;
		}


		Touch touch = Input.GetTouch (0);
		
		// ゲーム中ではなく、タッチ直後であればtrueを返す。
		if (touch.phase == TouchPhase.Began) {
			
			result(Application.loadedLevelName);
			
		}


	}

	void result(string sceneName){
		
		switch(sceneName) {
		case "Result1":
			goScene = "Scene2";
			break;
		case "Result2":
			goScene = "Eprolouge1";
			break;
		case "Result3":
			goScene = "Scene4";
			break;
		case "Result4":
			goScene = "Eprolouge2";
			break;
		case "Result5":
			goScene = "Scene6";
			break;
		case "Result6":
			goScene = "SEprolouge3";
			break;
		case "Result7":
			goScene = "Scene8";
			break;
		case "Result8":
			goScene = "Eprolouge14";
			break;
		default :
			goScene = "Gameover";
			break;
		}
		
		
		
		
		Application.LoadLevel(goScene);
	}
}
