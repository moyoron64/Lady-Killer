using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]
public class Player : MonoBehaviour {

/*--------------------------------------------------------
  初期設定
--------------------------------------------------------*/
	static public int waterLife = 22; // 中身の残量
	static public bool isActive = true;
	static public float xPosition;
	static public Vector2 velocity;
	        public float speed = 5;


	public Vector3 startPosition; // ゲーム開始時の初期位置
	public int jumpForce = 1;

	private bool jump = false;
	private bool isGrounded  = true ;
	float lastZ;

	void Start(){
		startPosition = transform.localPosition;
		waterLife = 22;
		isActive = true;
	}


	void Update()
	{
		if (waterLife == 0) {
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

		xPosition = transform.localPosition.x; // 自身の現在地を更新、goal判定に使用

		float x = Input.GetAxisRaw ("Horizontal");

                // 上・下
                float y = Input.GetAxisRaw ("Vertical");

                // 移動する向きを求める
                Vector2 direction = new Vector2 (x, y).normalized;

                // 移動する向きとスピードを代入する
                rigidbody2D.velocity = direction * speed;
		Move();
		Jump();

		float g = Input.acceleration.magnitude - 1.0f;
		lastZ = (lastZ + g) * 0.9f;

		if ( lastZ > 0.7f && jump == false) {
			jump = true;
		}

		velocity = rigidbody2D.velocity;
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

		/*
		transform.localPosition = startPosition;
		transform.eulerAngles = new Vector3(0, 0, 0);
		*/

		Application.LoadLevel ("Scene1");
	}
}