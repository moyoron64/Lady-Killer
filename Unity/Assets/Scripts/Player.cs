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
	public static bool isGrounded  = true ;
	float lastZ;
	public float moveSpeed = 150f;
	public float maxWalkSpeed = 1f; 
	public static float sokudo;
	GameObject slip1,slip2,slip3;

	void Start(){
		startPosition = transform.localPosition;
		waterLife = 22;
		isActive = true;
		maxjump = jumpForce;
		isGrounded = true;
		jumpForce = 0;
		slip1 = GameObject.Find("slip1");
		slip2 = GameObject.Find("slip2");
		slip3 = GameObject.Find("slip3");
	}


	void Update()
	{
		//Debug.Log ("speeeeeeeeeeed = " + rigidbody2D.velocity.x);
		if(Goal.clearFlag == true )return;

		if (Timer.timer < 0.0f && isActive) {
			Invoke("resetStage", 1);
		}

		if (waterLife == 0 && isActive) {
			isActive = false;
			Invoke("resetStage", 1);
		}

		float g = Input.acceleration.magnitude - 1.0f;
		lastZ = (lastZ + g) * 0.9f;
		
		if ( lastZ > 0.7f && jump == false &&  isGrounded==true) {
			jump = true;
			jumpForce = maxjump;
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
		if(Goal.clearFlag == true )return;
		//float x = Input.GetAxisRaw ("Horizontal");

                // 上・下
                //float y = Input.GetAxisRaw ("Vertical");

                // 移動する向きを求める
                //Vector2 direction = new Vector2 (x, y).normalized;

                // 移動する向きとスピードを代入する
                //rigidbody2D.velocity = direction * speed;







		sokudo = rigidbody2D.velocity.x;

		Move();
		Jump();
		Fall();
		Slip();


		

		
		if (Mathf.Abs (rigidbody2D.velocity.x) > maxWalkSpeed) {
			rigidbody2D.velocity = new Vector2 (
				Mathf.Sign(rigidbody2D.velocity.x) * maxWalkSpeed,rigidbody2D.velocity.y);
		}

	}


	void Jump()
	{
		if(jump == true)
		{
			//rigidbody2D.velocity = (Vector2.up * jumpForce);
			rigidbody2D.AddForce(Vector2.up * jumpForce);
			isGrounded=false;
			jumpForce-= mainasu;
		    if(jumpForce<0)jumpForce=0;

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
			//Debug.Log("slipslipslipslisplsispslispslisplsip");
		}

		if (col.gameObject.tag == "slip") {
			rigidbody2D.AddForce (Vector2.right *  rigidbody2D.velocity.x * 1000000f);
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
		if (Mathf.Abs (rigidbody2D.velocity.x) < maxWalkSpeed) {
			//cRigidbody2D.velocity = new Vector2(moveSpeed * Input.acceleration.x, cRigidbody2D.velocity.y);

			//rigidbody2D.velocity = (Vector2.right * moveSpeed * Input.acceleration.x);
			rigidbody2D.AddForce (Vector2.right * moveSpeed * Input.acceleration.x);
		}

	}

	void Slip(){
		if (System.Math.Abs (slip1.transform.position.x - this.transform.position.x) < 1) {
			rigidbody2D.AddForce (Vector2.right * rigidbody2D.velocity.x * 5f);
		}

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