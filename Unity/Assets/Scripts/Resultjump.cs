using UnityEngine;
using System.Collections;

public class Resultjump : MonoBehaviour {


	public float startTime = 4f;
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


		Touch touch = Input.GetTouch (0);
		
		// ゲーム中ではなく、タッチ直後であればtrueを返す。
		if (touch.phase == TouchPhase.Began) {
			
			Application.LoadLevel(goScene);
			return;
			
		}


	}
}
