using UnityEngine;
using System.Collections;

public class popWindow : MonoBehaviour {


	GameObject pop1,pop2,pop3,pop4,pop5;
	public int game = 1;
	public bool stopOk = false;

	// Use this for initialization
	void Start () {

		pop1 = GameObject.Find("Pop");
		pop2 = GameObject.Find("go");
		pop3 = GameObject.Find("ready");
		pop4 = GameObject.Find("stage");
		pop5 = GameObject.Find("number");
		pop1.renderer.enabled = false;
		pop2.renderer.enabled = false;
		pop3.renderer.enabled = false;
		pop4.renderer.enabled = false;
		pop5.renderer.enabled = false;
		stopOk = false;
	
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
				if(hitObject.collider.gameObject.name =="STOP"  && stopOk ==false){

					SoundManager.Instance.PlaySE(17);
					Time.timeScale = 0;
					pop1.renderer.enabled = true;
					pop2.renderer.enabled = true;
					pop3.renderer.enabled = true;
					pop4.renderer.enabled = true;
					pop5.renderer.enabled = true;
					stopOk = true;
					return;


				}

				else if(hitObject.collider.gameObject.name =="STOP" && stopOk == true ){
					
					
					pop1.renderer.enabled = false;
					pop2.renderer.enabled = false;
					pop3.renderer.enabled = false;
					pop4.renderer.enabled = false;
					pop5.renderer.enabled = false;
					Time.timeScale = 1;
					stopOk = false;
					SoundManager.Instance.PlaySE(17);
				}

				else if(hitObject.collider.gameObject.name =="ready" && stopOk == true){
					Time.timeScale = 1;
					pop1.renderer.enabled = false;
					pop2.renderer.enabled = false;
					pop3.renderer.enabled = false;
					pop4.renderer.enabled = false;
					pop5.renderer.enabled = false;
					game=1;
					SoundManager.Instance.PlaySE(17);
				}
				else  if(hitObject.collider.gameObject.name == "go" && stopOk == true){
					Time.timeScale = 1;
					Application.LoadLevel("Title");
					SoundManager.Instance.PlaySE(16);
				}
			}
		}
	
	}
}
