using UnityEngine;
using System.Collections;

public class fadeOutWater : MonoBehaviour {

	bool isGrounded;
	float scaleDown;
	// Use this for initialization
	void Start () {
		isGrounded = false;
		scaleDown = 0;
	}

	// Update is called once per frame
	void Update () {
	if (isGrounded) {

			float x = transform.localScale.x;
			scaleDown += 0.08f;
			transform.localScale = new Vector3 (x - scaleDown, x - scaleDown, x);

		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "yuka") {
			isGrounded = true;
			//Debug.Log("slipslipslipslisplsispslispslisplsip");
		}
	}
}
