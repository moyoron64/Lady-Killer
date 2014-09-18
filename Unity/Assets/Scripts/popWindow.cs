using UnityEngine;
using System.Collections;

public class popWindow : MonoBehaviour {


	GameObject pop1,pop2,pop3;
	public int game = 1;

	// Use this for initialization
	void Start () {

		pop1 = GameObject.Find("Pop");
		pop2 = GameObject.Find("go");
		pop3 = GameObject.Find("ready");
		pop1.renderer.enabled = false;
		pop2.renderer.enabled = false;
		pop3.renderer.enabled = false;
	
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
				if(hitObject.collider.gameObject.name =="STOP"){
					Time.timeScale = 0;
					pop1.renderer.enabled = true;
					pop2.renderer.enabled = true;
					pop3.renderer.enabled = true;
					return;
				}

				if(hitObject.collider.gameObject.name =="ready"){
					Time.timeScale = 1;
					pop1.renderer.enabled = false;
					pop2.renderer.enabled = false;
					pop3.renderer.enabled = false;
					game=1;
				}
				if(hitObject.collider.gameObject.name =="go"){
					Application.LoadLevel("Title");
					Time.timeScale = 1;
				}
			}
		}
	
	}
}
