using UnityEngine;
using System.Collections;

public class Skip : MonoBehaviour {

	public float lastTime = 7f;
	public bool skip = false;
	
	private float currentRemainTime;
	private SpriteRenderer spRenderer;
	
	// Use this for initialization
	void Start () {
		// 初期化
		
		spRenderer = GetComponent<SpriteRenderer>();
		float alpha = 0;
		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
		
	}
	
	// Update is called once per frame
	void Update () {
		// 残り時間を更新
		
		lastTime -= Time.deltaTime;
		
		if (lastTime >= 0f) {

			// タッチ情報を取得する
			Touch touch = Input.GetTouch (0);

			// ゲーム中ではなく、タッチ直後であればtrueを返す。
			if (touch.phase == TouchPhase.Began) {

					float alpha = 1f;
					var color = spRenderer.color;
					color.a = alpha;
					spRenderer.color = color;
					skip = true;
					lastTime = -1f;
					return;
					
			}





		} else {
			skip = true;
		}

		Touch skiptouch = Input.GetTouch (0);
		
		// ゲーム中ではなく、タッチ直後であればtrueを返す。
		if (skiptouch.phase == TouchPhase.Began) {

		if(skip == true){
			
			Application.LoadLevel("Load");
			
		}

		}



	}
}