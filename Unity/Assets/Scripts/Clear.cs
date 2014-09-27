using UnityEngine;
using System.Collections;

public class Clear : MonoBehaviour {
	Animation anim;
	public float time = 2.0f;
	private string goScene;

	// Use this for initialization

	void Start () {

		anim = GetComponent<Animation>();

	


	}
	
	// Update is called once per frame
	void Update () {

		if (Goal.clearFlag == true) {
			anim.Play ("trueClear");
		}

		if (time < 0) {
			result(Application.loadedLevelName);
		}
		
	
	}
	void result(string sceneName){

		switch(sceneName) {
		case "Scene1":
			goScene = "Result1";
			break;
		case "Scene2":
			goScene = "Result2";
			break;
		case "Scene3":
			goScene = "Result3";
			break;
		case "Scene4":
			goScene = "Result4";
			break;
		case "Scene5":
			goScene = "Result5";
			break;
		case "Scene6":
			goScene = "Result6";
			break;
		case "Scene7":
			goScene = "Result7";
			break;
		case "Scene8":
			goScene = "Result8";
			break;
		default :
			goScene = "Gameover";
			break;
		}




		Application.LoadLevel(goScene);
	}

}
