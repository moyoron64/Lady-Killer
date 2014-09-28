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
		isActive = true;
		startPosition = transform.localPosition;
		glass = GameObject.Find("glass-kara");
	}

	// Update is called once per frame
	void Update () {
		// 水が地面にこぼれたときの処理
		if (!judgeWaterStatus() && isActive) {
			isActive = false;
			waterLost();
		}
		if (Player.waterLife == 0 && Player.isActive) {
			Invoke("resetStage", 3);
		}
		/*if (Input.GetKeyDown("a") && Player.jump==true) {
			rigidbody2D.AddForce(Vector2.up * Player.jumpForce);
		}*/
	}

	/*-----------------------------------
		水がこぼれたかどうか判定する関数
	-----------------------------------*/
	public bool judgeWaterStatus()
	{
		Vector3 wPosition = transform.localPosition; // 水の位置
		Vector3 gPosition = glass.transform.localPosition; // グラスの位置
		float gWidth = glass.transform.localScale.x; // グラスの幅

		// y座標の判定
		if (wPosition.y < gPosition.y && isActive) {
			return false;
		}

		//Debug.Log("wPosition" + wPosition.x);
		//Debug.Log("gPosition" + gPosition.x + gWidth/2);
		// x座標の判定
		if (((gPosition.x - wPosition. x) < -5 || 5 < (gPosition.x - wPosition.x))   && isActive) {
			return false;
		}
		return true;
	}




	public void waterLost()
	{
		Player.waterLife --;
		isActive = false;
	}

	public void resetStage()
	{
		// 同じシーンに戻ってくる
		isActive = true;
		Player.waterLife = 22;
		Application.LoadLevel (Application.loadedLevelName);
	}
}
