using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	// プロパティ
	float xSize; // x方向のサイズ
	float xPosition;
	float radius; //ゴールの半径
	static public float distance = 9.99f; // グラスとの距離
	public static bool clearFlag;
	GameObject glass;

	/*--------------------------------------------
	  初期化
	--------------------------------------------*/
	// Use this for initialization
	void Start () {
		glass = GameObject.FindGameObjectWithTag("kakuteru");
		xSize = renderer.bounds.size.x;
		xPosition = transform.localPosition.x;
		distance = 10;
		clearFlag = false;
	}

	// Update is called once per frame
	void Update () {
		Debug.Log(glass.transform.localPosition.x);
		Debug.Log(transform.localPosition.x);
		if (checkDistanceWithGlass(xPosition, Player.xPosition) && Player.xSokudo >= 0  && Player.isGrounded == true && Player.waterLife != 0 ) {
			// ゴールの半径内かつ速度が１以下ならシーン移動
			//Application.LoadLevel ("Result2");
			Player.life = 3;
			clearFlag = true;

		}
	}

	bool checkDistanceWithGlass(float goalPosition, float glassPosition) {

		if (clearFlag == false) {
			distance = System.Math.Abs(glassPosition - goalPosition);

			//Debug.Log("distance =" + distance + '/' + transform.localPosition.x + xSize/2 + '/' + Player2.transform.localPosition.x);
			if (glass.transform.localPosition.x < transform.localPosition.x) {
					return true;
			}
			/*
			if (distance < xSize / 2) {
					return true;
			}
			*/
		}
		return false;
	}
}


