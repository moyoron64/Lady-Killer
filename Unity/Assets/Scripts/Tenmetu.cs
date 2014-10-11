using UnityEngine;
using System.Collections;

public class Tenmetu : MonoBehaviour {
	public float fadeTime = 1f;
	public float startTime = 1f;
	float alpha;
	
	private float currentRemainTime;
	private float goTime;
	private SpriteRenderer spRenderer;
	public float tenmetu;
	public float tenmetuTime;
	int count;
	
	// Use this for initialization
	void Start () {
		// 初期化
		count = 0;
		currentRemainTime = fadeTime;
		goTime = startTime;
		tenmetuTime = 0;

		spRenderer = GetComponent<SpriteRenderer>();
		float alpha = 0;
		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
	
	}
	
	// Update is called once per frame
	void Update () {



		if ( goTime >= 0f ) {
			goTime -= Time.deltaTime;
			return;
		}

		tenmetuTime -= Time.deltaTime;
		if (tenmetuTime <= 0) {

			alpha = 1f;
		}
		if (tenmetuTime < -(tenmetu)) {
			tenmetuTime = tenmetu;
			alpha = 0f;
			count++;
			if(count >= 2 )tenmetuTime= 1000f;
		}

		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
	}
}