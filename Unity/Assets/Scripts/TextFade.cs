using UnityEngine;
using System.Collections;

public class TextFade : MonoBehaviour {
	public float fadeTime = 1f;
	public float startTime = 1f;
	
	private float currentRemainTime;
	private float goTime;
	private SpriteRenderer spRenderer;
	
	// Use this for initialization
	void Start () {
		// 初期化
		currentRemainTime = fadeTime;
		goTime = startTime;


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
		currentRemainTime -= Time.deltaTime;

		float alpha = 1f - currentRemainTime / fadeTime;
		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
		Debug.Log (color);
	}
}