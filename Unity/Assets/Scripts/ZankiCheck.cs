using UnityEngine;
using System.Collections;

public class zankiWindow2 : MonoBehaviour {

	GameObject go,go2,go3;
	// Use this for initialization
	void Start () {
		
		
		
		

		go = GameObject.Find("zanki1");
		go2 = GameObject.Find("zanki2");
		go3 = GameObject.Find("zanki3");
		
		
		
	
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Player.life == 0) {
			go.renderer.enabled = false;
		}
		if (Player.life == 1) {
			go2.renderer.enabled = false;
		}
		if (Player.life == 2) {
			go3.renderer.enabled = false;
		}

	}
}
