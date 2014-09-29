using UnityEngine;
using System.Collections;

public class Gameover : MonoBehaviour {

	public float fadeTime = 4f;
	
	private float currentRemainTime;
	private float goTime;
	public string goScene;
	private SpriteRenderer spRenderer;
	
	// Use this for initialization
	void Start () {
		// 初期化
		currentRemainTime = fadeTime;
			

		
	}
	
	// Update is called once per frame
	void Update () {
		// 残り時間を更新
		
		currentRemainTime -= Time.deltaTime;
		
		if ( currentRemainTime <= 0f ) {
			// 残り時間が無くなったら自分自身を消滅
			Application.LoadLevel(goScene);
			return;
		}

		
	}
}