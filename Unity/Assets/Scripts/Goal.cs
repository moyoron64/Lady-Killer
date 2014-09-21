using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	// プロパティ
	float xSize; // x方向のサイズ
	float xPosition;
	static public float distance; // グラスとの距離

	/*--------------------------------------------
	  初期化
	--------------------------------------------*/
	// Use this for initialization
	void Start () {
		xSize = transform.lossyScale.x;
		xPosition = transform.localPosition.x;
		distance = 10;
	}

	// Update is called once per frame
	void Update () {
		if (checkDistanceWithGlass(xPosition, Player.xPosition) && Input.acceleration.x > -0.1) {
			// ゴールの半径内かつ速度が１以下ならシーン移動
			Application.LoadLevel ("Result2");
		}
		Debug.Log (Input.acceleration.x);
	}

	bool checkDistanceWithGlass(float goalPosition, float glassPosition) {
		distance = glassPosition - goalPosition;

		if (distance < xSize/2) {
			return true;
		}

		return false;
	}
}


