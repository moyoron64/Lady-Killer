using UnityEngine;
using System.Collections;
[RequireComponent(typeof(Rigidbody2D))]

public class Dish : MonoBehaviour {
	bool isReuse = true;
	Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.localPosition;
	}

	// Update is called once per frame
	void Update () {
		if (isReuse) {

			Vector2 direction = new Vector2 (10, 0).normalized;

			rigidbody2D.velocity =  direction * Random.Range(100,120);
			isReuse = false;
		}

		if (transform.localPosition.x > GameObject.Find("glass-kara").transform.localPosition.x) {
			transform.localPosition = startPosition;
			isReuse = true;
		}
	}
}
