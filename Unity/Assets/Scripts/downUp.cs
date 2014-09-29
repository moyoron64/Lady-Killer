using UnityEngine;
using System.Collections;
/**
 * 足場を上下に動かす関数
 *
 */

public class downUp : MonoBehaviour {
	public Vector3 position;
	public bool returnFlug = false;
	public float speed;

	// Use this for initialization
	void Start () {
		speed = Random.Range(3, 5);
		position = transform.localPosition;
	}

	// Update is called once per frame
	void Update () {


		if (returnFlug) {
			rigidbody2D.velocity  =  ( Vector2.up * speed * -1);
			if (transform.localPosition.y < position.y - 5.0f) {
				returnFlug = false;
			}
		} else {
			rigidbody2D.velocity  =  ( Vector2.up * speed );
			if (transform.localPosition.y > position.y + 5.0f) {
				returnFlug = true;
			}
		}
	}
}
