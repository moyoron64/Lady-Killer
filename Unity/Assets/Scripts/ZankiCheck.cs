using UnityEngine;
using System.Collections;

public class zankiWindow2 : MonoBehaviour {
	GUILayer guiLayer;
	GUITexture zanki1;
	GUITexture zanki2;
	GUITexture zanki3;
	// Use this for initialization
	void Start () {
		
		
		
		
		guiLayer = Camera.main.GetComponent<GUILayer>();
		
		
		GameObject go = GameObject.Find("zanki1");
		GameObject go2 = GameObject.Find("zanki2");
		GameObject go3 = GameObject.Find("zanki3");
		zanki1 = (GUITexture)go.GetComponent(typeof(GUITexture));
		zanki2 = (GUITexture)go2.GetComponent(typeof(GUITexture));
		zanki3 = (GUITexture)go3.GetComponent(typeof(GUITexture));
		
		
		
	
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Player.life == 0) {
			zanki1.guiTexture.enabled = false;
		}
		if (Player.life == 1) {
			zanki2.guiTexture.enabled = false;
		}
		if (Player.life == 2) {
			zanki3.guiTexture.enabled = false;
		}

	}
}
