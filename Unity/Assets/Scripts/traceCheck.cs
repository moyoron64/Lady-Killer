using UnityEngine;
using System.Collections;

public class traceCheck : MonoBehaviour {

	public float speed = 5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = Vector2.MoveTowards(transform.position, new Vector2(Player.xPosition, transform.position.y), speed );	}
}
