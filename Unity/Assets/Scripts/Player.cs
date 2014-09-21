using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PolygonCollider2D))]
public class Player : MonoBehaviour {

/*--------------------------------------------------------
  初期設定
--------------------------------------------------------*/
	static public int life = 3;
	static public int waterLife = 22; // 中身の残量
	static public bool isActive = true;
	static public float xPosition;
	static public Vector2 velocity;
	        public float speed = 5;


	public Vector3 startPosition; // ゲーム開始時の初期位置
	public float jumpForce = 1f;
	public float mainasu = 1f;
	public float maxjump;

	public static bool jump = false;
	private bool isGrounded  = true ;
	float lastZ;
	public float moveSpeed = 150f;

	void Start(){
		startPosition = transform.localPosition;
		waterLife = 22;
		isActive = true;
		maxjump = jumpForce;
		jumpForce = 0;
	}


	void Update()
	{
		if (Timer.timer < 0.0f && isActive) {
			Invoke("resetStage", 1);
		}

		if (waterLife == 0 && isActive) {
			isActive = false;
			Invoke("resetStage", 3);
		}

		if (Input.GetKeyDown("a")&& jump == false &&  isGrounded==true) {
			jump=true;
			jumpForce = maxjump;
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



	void FixedUpdate()
	{

		xPosition = transform.localPosition.x; // 自身の現在地を更新、goal判定に使用

		//float x = Input.GetAxisRaw ("Horizontal");

                // 上・下
                //float y = Input.GetAxisRaw ("Vertical");

                // 移動する向きを求める
                //Vector2 direction = new Vector2 (x, y).normalized;

                // 移動する向きとスピードを代入する
                //rigidbody2D.velocity = direction * speed;





		float g = Input.acceleration.magnitude - 1.0f;
		lastZ = (lastZ + g) * 0.9f;

		if ( lastZ > 0.7f && jump == false &&  isGrounded==true) {
			jump = true;
			jumpForce = maxjump;
		}

		velocity = rigidbody2D.velocity;

		Move();
		Jump();
		Fall();



	}


	void Jump()
	{
		if(jump == true)
		{
			rigidbody2D.velocity = (Vector2.up * jumpForce);
			isGrounded=false;
			jumpForce-= mainasu;
			//if(jumpForce<0)jumpForce=0;

		}

	}

	void Fall()
	{
		/*
		if(jump == false && isGrounded == false)
		{
			rigidbody2D.velocity = (Vector2.up * jumpForce);
			isGrounded=false;
			jumpForce-= mainasu;
			//if(jumpForce<0)jumpForce=0;
			
		}
		*/
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "yuka") {
			isGrounded = true;
			jump = false;
		}
	}

	
	/*void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == "yuka") {
			isGrounded = false;
		}
	}
	*/
	void Move()
	{
		//cRigidbody2D.velocity = new Vector2(moveSpeed * Input.acceleration.x, cRigidbody2D.velocity.y);

		//rigidbody2D.velocity = (Vector2.right * moveSpeed * Input.acceleration.x);
		rigidbody2D.AddForce(Vector2.right * moveSpeed * Input.acceleration.x );

	}

	// 水が全てこぼれたらステージをリセット
	void resetStage()
	{

		/*
		transform.localPosition = startPosition;
		transform.eulerAngles = new Vector3(0, 0, 0);
		*/

		life --;

		if (life == -1 ) {
			Application.LoadLevel("Gameover");
			return;
		}

		Application.LoadLevel (Application.loadedLevelName);


	}
}