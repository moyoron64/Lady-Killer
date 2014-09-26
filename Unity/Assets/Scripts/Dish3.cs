using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody2D))]

public class Dish3 : MonoBehaviour {
	bool isReuse = true;
	Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.localPosition;
	}

	// Update is called once per frame
	void Update () {
		if (isReuse) {

			//Vector2 direction = new Vector2 (10, 0).normalized;

			isReuse = false;
		}
		Vector2 direction = new Vector2 (10, 0).normalized;
		
		rigidbody2D.velocity =  direction * 16;

		if (transform.localPosition.y <  -2) {
			resetPosition();
		}
	}

	public void resetPosition()
	{
			transform.localPosition = startPosition;
			isReuse = true;
	}

	void jumpTrue(){

	}
}
