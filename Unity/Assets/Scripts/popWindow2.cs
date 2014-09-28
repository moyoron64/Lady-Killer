using UnityEngine;
using System.Collections;

public class popWindow2 : MonoBehaviour {
	GUILayer guiLayer;
	GUITexture pop1;
	GUITexture pop2;
	GUITexture pop3;
	public bool stopOk = false;
	// Use this for initialization
	void Start () {

		stopOk = false;


		guiLayer = Camera.main.GetComponent<GUILayer>();


		GameObject go = GameObject.Find("POP");
		GameObject go2 = GameObject.Find("go");
		GameObject go3 = GameObject.Find("ready");
		pop1 = (GUITexture)go.GetComponent(typeof(GUITexture));
		pop2 = (GUITexture)go2.GetComponent(typeof(GUITexture));
		pop3 = (GUITexture)go3.GetComponent(typeof(GUITexture));

	

		pop1.guiTexture.enabled = false;
		pop2.guiTexture.enabled = false;
		pop3.guiTexture.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {


		Touch touch = Input.GetTouch (0);
		if (touch.phase != TouchPhase.Began)return;


		GUIElement hit = guiLayer.HitTest (touch.position);

		if (Input.GetMouseButtonDown (0) && hit != null) {
			if(hit.name == "STOP"){


				pop1.guiTexture.enabled = true;
				pop2.guiTexture.enabled = true;
				pop3.guiTexture.enabled = true;
				Time.timeScale = 0;
				stopOk = true;
				
			}
			if(hit.name == "go"&&stopOk == true){

				Time.timeScale = 1;
				pop1.guiTexture.enabled = false;
				pop2.guiTexture.enabled = false;
				pop3.guiTexture.enabled = false;
				stopOk = false;

			}
			if(hit.name == "ready" && stopOk == true){
				Time.timeScale = 1;
				Application.LoadLevel("Title");
			}
		}
	
	}
}
