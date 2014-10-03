using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {


	void Start () {


		float me = PlayerPrefs.GetFloat("BGM",1f);
		float se = PlayerPrefs.GetFloat("SE",1f );

		SoundManager.Instance.volume.BGM = me; 
		SoundManager.Instance.volume.SE = se; 



		SoundManager.Instance.PlayBGM(3);
		PlayerPrefs.SetInt("sumScore", 0);

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
				if(hitObject.collider.gameObject.name =="START"){
					FadeManager.Instance.LoadLevel("Prologue",0.5f);
					SoundManager.Instance.PlaySE(15);
					SoundManager.Instance.StopBGM();
				}
				if(hitObject.collider.gameObject.name =="OPTION"){
					Application.LoadLevel("Option");
					SoundManager.Instance.PlaySE(17);
				}
				if(hitObject.collider.gameObject.name =="BACK"){
					Application.LoadLevel("Title");
					SoundManager.Instance.PlaySE(16);
				}
			}
		}

}
}

