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

		if (Goal.clearFlag == true) {
			anim.Play ("clear");
		}

		if (time < 0) {
			result();
		}
		
	
	}
	void result(){
		Application.LoadLevel (Application.loadedLevelName);
	}

}
