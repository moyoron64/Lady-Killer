using UnityEngine;
using System.Collections;

public class touchJump : MonoBehaviour {
	public float touchTime = 1f;
	public float autoTime = 1f;

	
	private float currentRemainTime;
	private float goTime;
	private SpriteRenderer spRenderer;
	private bool touchOk; 
	public string goScene;
	
	// Use this for initialization
	void Start () {
		// 初期化
		currentRemainTime = touchTime;
		goTime = autoTime;
		touchOk = false;
		
		
		spRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {


		currentRemainTime -= Time.deltaTime;
		goTime -= Time.deltaTime;

		if ( currentRemainTime >= 0f ) {
			touchOk = true;
		}

		if (touchOk == true) {
			Touch touch = Input.GetTouch (0);

			// ゲーム中ではなく、タッチ直後であればtrueを返す。
			if (touch.phase == TouchPhase.Began) {

					Application.LoadLevel(goScene);

			}
		}



		if ( goTime >= 0f ) {
			return;
		}

		Application.LoadLevel ("totalScore"); 
	}
}