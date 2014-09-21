using UnityEngine;
using System.Collections;

public class Alpha : MonoBehaviour {

	public float alpha = 0.1f;
	private SpriteRenderer spRenderer;
	// Use this for initialization
	void Start () {

		spRenderer = GetComponent<SpriteRenderer>();

		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
	}
	
	// Update is called once per frame
	void Update () {

		spRenderer = GetComponent<SpriteRenderer>();
		
		var color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
	
	}
}
