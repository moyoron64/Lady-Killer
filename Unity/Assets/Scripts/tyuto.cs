using UnityEngine;
using System.Collections;

public class tyuto : MonoBehaviour {
	GameObject TA,TB,TC;
	private int tPage;
	// Use this for initialization
	void Start () {
		
		TA = GameObject.Find("T1");
		TB = GameObject.Find("T2");
		TC = GameObject.Find("T3");
	
		
		
		TA.renderer.enabled = true;
		TB.renderer.enabled = false;
		TC.renderer.enabled = false;
	
		
		
		tPage = 0;
		
		
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount == 1) {
			
			Touch touch = Input.GetTouch (0);
			
			if (touch.phase != TouchPhase.Began)return;
			
			
			Vector2 tapPoint = Camera.main.ScreenToWorldPoint(touch.position);
			Collider2D colition2d = Physics2D.OverlapPoint(tapPoint);
			
			if(colition2d) {
				RaycastHit2D hitObject = Physics2D.Raycast(tapPoint, -Vector2.up);
				if(hitObject.collider.gameObject.name =="GO"){
					tPage++;
					SoundManager.Instance.PlaySE(17);

				}
				if(hitObject.collider.gameObject.name =="BACK" && tPage != 0){
					tPage--;
					SoundManager.Instance.PlaySE(9);
				}

			}
		}


		if (tPage == 0) {
			TA.renderer.enabled = true;
			TB.renderer.enabled = false;
			TC.renderer.enabled = false;
		}

		if (tPage == 1) {
			TA.renderer.enabled = false;
			TB.renderer.enabled = true;
			TC.renderer.enabled = false;
		}

		if (tPage == 2) {
			TA.renderer.enabled = false;
			TB.renderer.enabled = false;
			TC.renderer.enabled = true;
		}

		if (tPage == 3) {

			Application.LoadLevel("Scene1");
		}


		
		
	}
}
