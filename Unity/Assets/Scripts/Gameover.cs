using UnityEngine;
using System.Collections;

public class Gameover : MonoBehaviour {

	public float fadeTime = 4f;
	
	private float currentRemainTime;
	private float goTime;
	private SpriteRenderer spRenderer;
	
	// Use this for initialization
	void Start () {
		// 初期化
		currentRemainTime = fadeTime;
		spRenderer = GetComponent<SpriteRenderer>();
			

		
	}
	
	// Update is called once per frame
	void Update () {
		// 残り時間を更新
		
		
		
		if ( currentRemainTime <= -2f ) {
			// 残り時間が無くなったら自分自身を消滅
			Application.LoadLevel("Title");
			return;
		}
		currentRemainTime -= Time.deltaTime;
		
		// フェードアウト
		float alpha = currentRemainTime / fadeTime;
		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
	}
}