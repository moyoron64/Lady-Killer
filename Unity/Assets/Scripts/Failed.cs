using UnityEngine;
using System.Collections;

public class Failed : MonoBehaviour {
	Animation anim;
	public float time = 2.0f;

	// Use this for initialization

	void Start () {

		anim = GetComponent<Animation>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Player.failedFlag == true) {
			anim.Play ("clear");
		}

		if (time < 0) {
			result();
		}
		
	
	}
	void result(){


		Player.life --;
		
		if (Player.life == -1 ) {
			Application.LoadLevel("Gameover");
			return;
		}
		
		Application.LoadLevel (Application.loadedLevelName);
	}

}
