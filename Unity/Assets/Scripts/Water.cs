using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour {
/*--------------------------------------------------------
  初期設定
--------------------------------------------------------*/
	bool isActive = true;
	GameObject glass;
	Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.localPosition;
		glass = GameObject.Find("glass-kara");
	}

	// Update is called once per frame
	void Update () {
		// 水が地面にこぼれたときの処理
		if (transform.localPosition.y < glass.transform.localPosition.y && isActive) {
			waterLost();
		}
		/*
		if (Player.waterLife == 0 && Player.isActive) {
			Invoke("resetStage", 3);
		}
		*/
		/*if (Input.GetKeyDown("a") && Player.jump==true) {
			rigidbody2D.AddForce(Vector2.up * Player.jumpForce);
		}*/
	}



	public void waterLost()
	{
		Player.waterLife --;
		isActive = false;
	}

	public void resetStage()
	{
		// 同じシーンに戻ってくる
		Application.LoadLevel (Application.loadedLevelName);
	}
}
