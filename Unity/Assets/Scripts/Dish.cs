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

			//Vector2 direction = new Vector2 (10, 0).normalized;

			isReuse = false;
		}
		Vector2 direction = new Vector2 (10, 0).normalized;
		
		rigidbody2D.velocity =  direction * 16;
		
		if (transform.localPosition.x > GameObject.Find("glass-kara").transform.localPosition.x + 10f) {
			resetPosition();
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		
		

		
		if (col.gameObject.tag == "slip"    ) {
			rigidbody2D.AddForce (Vector2.right * rigidbody2D.velocity.x * 130f);
			
		}
		
		
		
	}

	public void resetPosition()
	{
			transform.localPosition = startPosition;
			isReuse = true;
	}
}
