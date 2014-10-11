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
	static public Color waterColor;         // 中身の色
	static public bool isActive = true;
	static public float xPosition;
	static public bool isNextStage = false;
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
	public static float ySokudo;
	public static float xSokudo;
	GameObject slip1,slip2,slip3,slip4;
	private int slip1Count,slip2Count,slip3Count,slip4Count;
	public int slip = 0;
	public float zCheck;
	public static bool failedFlag;
	public static float myXRole;

	void Start(){
		waterColor = new Color(0.5f, 1.0f, 1.0f, 1.0f);
		startPosition = transform.localPosition;
		waterLife = 22;
		isActive = true;
		maxjump = jumpForce;
		isGrounded = true;
		jump = false;
		jumpForce = 0;
		slip1 = GameObject.Find("slip1");
		slip2 = GameObject.Find("slip2");
		slip3 = GameObject.Find("slip3");
		slip4 = GameObject.Find("slip4");
		slip1Count = 0;
		slip2Count = 0;
		slip3Count = 0;
		slip4Count = 0;
		failedFlag = false;
		SoundManager.Instance.PlayBGM (2);
}


	void Update()
	{
		xPosition = transform.localPosition.x;
		//Debug.Log ("speeeeeeeeeeed = " + rigidbody2D.velocity.x);
		float zCheck;
		if((Goal.clearFlag == true) || (failedFlag == true) || (readyGo.startFlag == false) )return;

		if (Timer.timer < 0.0f && isActive) {
			isActive = false;
			resetStage();
		}

		if (waterLife == 0 && isActive) {
			isActive = false;
			resetStage();
		}

		float g = Input.acceleration.magnitude;


		//Debug.Log ("accelerationaaaaa = "+Input.acceleration.magnitude);

		if ( g > 1.47f && jump == false &&  isGrounded==true) {
			jump = true;
			jumpForce = maxjump;
			if(System.Math.Abs(transform.rotation.z)  < 340 &&(System.Math.Abs(transform.rotation.z)  <  65  || System.Math.Abs(transform.rotation.z)  <  295)){
				//SoundManager.Instance.PlaySE(13);
			}

		}

		if (Input.GetKeyDown("a")&& jump == false &&  isGrounded==true) {
			jump=true;
			jumpForce = maxjump;
			//SoundManager.Instance.PlaySE(13);
		}
		if (transform.position.y < -1)resetStage();


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
		myXRole = transform.rotation.z;
		 // 自身の現在地を更新、goal判定に使用
		if((Goal.clearFlag == true) || (failedFlag == true) || (readyGo.startFlag == false))return;
		/*float x = Input.GetAxisRaw ("Horizontal");

                // 上・下
                float y = Input.GetAxisRaw ("Vertical");

                // 移動する向きを求める
                Vector2 direction = new Vector2 (x, y).normalized;

                // 移動する向きとスピードを代入する
                rigidbody2D.velocity = direction * speed;

		*/







		xSokudo = rigidbody2D.velocity.x;
		ySokudo = rigidbody2D.velocity.y;
		Move();
		Jump();
		//Fall();
		//if(slip==1)Slip();





		if (Mathf.Abs (rigidbody2D.velocity.x) > maxWalkSpeed) {
			rigidbody2D.velocity = new Vector2 (
				Mathf.Sign(rigidbody2D.velocity.x) * maxWalkSpeed,rigidbody2D.velocity.y);
		}



	}



	void noRole(){

		if (Attack.attackBool == true && isGrounded == false) {
			transform.eulerAngles = new Vector3 (Attack.xRole, transform.eulerAngles.y, transform.eulerAngles.y);
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

	/*void Fall()
	{

		if(jump == false && isGrounded == false)
		{
			rigidbody2D.velocity = (Vector2.up * jumpForce);
			isGrounded=false;
			jumpForce-= mainasu;
			//if(jumpForce<0)jumpForce=0;

		}


	}*/
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("slip") ){ //ジャンプで当たった
			Debug.Log("aaaaaaaaaaaaaaaaaaa");
			rigidbody2D.AddForce (Vector2.right * rigidbody2D.velocity.x * 10f);
			SoundManager.Instance.PlaySE(19);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{



		if (col.gameObject.tag == "yuka" && ySokudo <= 0   ) {
			isGrounded = true;

			//Debug.Log("slipslipslipslisplsispslispslisplsip");


		}









	}


	/*void OnCollisionExit2D(Collision2D col)
	{
		if (col.gameObject.tag == "yuka") {
			isGrounded = false;
		}
	}*/

	void Move()
	{
		if (Mathf.Abs (rigidbody2D.velocity.x) < maxWalkSpeed) {
			//cRigidbody2D.velocity = new Vector2(moveSpeed * Input.acceleration.x, cRigidbody2D.velocity.y);

			//rigidbody2D.velocity = (Vector2.right * moveSpeed * Input.acceleration.x);
			rigidbody2D.AddForce (Vector2.right * moveSpeed * Input.acceleration.x);

		}

	}
	/*
	void Slip(){
		if (System.Math.Abs (slip1.transform.position.x - this.transform.position.x) < 2 && slip1Count ==0 && Player.isGrounded == true) {
			rigidbody2D.AddForce (Vector2.right * rigidbody2D.velocity.x * 130f);
			slip1Count++;
		}

		if (System.Math.Abs (slip2.transform.position.x - this.transform.position.x) < 2 && slip2Count ==0 && Player.isGrounded == true) {
			rigidbody2D.AddForce (Vector2.right * rigidbody2D.velocity.x * 130f);
			slip2Count++;
		}

		if (System.Math.Abs (slip3.transform.position.x - this.transform.position.x) < 2 && slip3Count ==0 && Player.isGrounded == true) {
			rigidbody2D.AddForce (Vector2.right * rigidbody2D.velocity.x * 130f);
			slip3Count++;
		}

		if (System.Math.Abs (slip4.transform.position.x - this.transform.position.x) < 2.5 && slip4Count ==0 && Player.isGrounded == true) {
			rigidbody2D.AddForce (Vector2.right * rigidbody2D.velocity.x * 130f);
			slip4Count++;
		}


	}*/



	// 水が全てこぼれたらステージをリセット
	void resetStage()
	{


		life --;
		failedFlag = true;
		SoundManager.Instance.PlaySE (5);
		SoundManager.Instance.StopBGM ();
		/*
		transform.localPosition = startPosition;
		transform.eulerAngles = new Vector3(0, 0, 0);
		*/




	}
}