using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {
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
	}
	
	// Update is called once per frame
	void Update () {
		
		
		
		if ( goTime >= 0f ) {
			goTime -= Time.deltaTime;
			return;
		}
		currentRemainTime -= Time.deltaTime;
		
		float alpha = currentRemainTime / fadeTime;
		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
		Debug.Log (color);
	}
}