using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]
public class Player : MonoBehaviour {

/*--------------------------------------------------------
  初期設定
--------------------------------------------------------*/
	static public int waterLife = 6; // 中身の残量
	static public bool isActive = true;

	public Vector3 startPosition; // ゲーム開始時の初期位置
	public int jumpForce = 1;

	private bool jump = false;
	private bool isGrounded  = true ;
	float lastZ;

	void Start(){
		startPosition = transform.localPosition;
	}


	void Update()
	{
		if (waterLife == 0 && isActive) {
			isActive = false;
			Invoke("resetStage", 3);
		}
	}


	public Rigidbody2D cRigidbody2D
	{
		get
		{
			if(!_cRigidbody2D)
				_cRigidbody2D = rigidbody2D;
			return _cRigidbody2D;
		}
	}
	Rigidbody2D _cRigidbody2D;

	public float moveSpeed = 5;

	void FixedUpdate()
	{
		Move();
		Jump();

		float g = Input.acceleration.magnitude - 1.0f;
		lastZ = (lastZ + g) * 0.9f;

		if ( lastZ > 0.7f && jump == false) {
			jump = true;
		}
	}


	void Jump()
	{
		if(jump == true &&  isGrounded)
		{
			rigidbody2D.AddForce(Vector2.up * 600f);
			Debug.Log("spaceon");
			isGrounded=false;
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "yuka")
			isGrounded = true;
			jump = false;
	}

	void Move()
	{
			cRigidbody2D.velocity = new Vector2(moveSpeed * Input.acceleration.x, cRigidbody2D.velocity.y);
	}

	// 水が全てこぼれたらステージをリセット
	void resetStage()
	{
		transform.localPosition = startPosition;
	}
}