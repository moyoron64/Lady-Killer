using UnityEngine;
using System.Collections;

public class Resultjump : MonoBehaviour {

	// Use this for initialization
	void Start () {




	
	}
	
	// Update is called once per frame
	void Update () {

		Touch touch = Input.GetTouch (0);
		
		// ゲーム中ではなく、タッチ直後であればtrueを返す。
		if (touch.phase == TouchPhase.Began) {
			
			Application.LoadLevel("Eprolouge");
			return;
			
		}


	}
}
