using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {
	// プロパティ
	float xSize; // x方向のサイズ
	float xPosition;
	static public float distance; // グラスとの距離
	public static bool clearFlag;

	/*--------------------------------------------
	  初期化
	--------------------------------------------*/
	// Use this for initialization
	void Start () {
		xSize = transform.lossyScale.x;
		xPosition = transform.localPosition.x;
		distance = 10;
		clearFlag = false;
	}

	// Update is called once per frame
	void Update () {
		if (checkDistanceWithGlass(xPosition, Player.xPosition) && Player.sokudo > -0.01) {
			// ゴールの半径内かつ速度が１以下ならシーン移動
			//Application.LoadLevel ("Result2");
			clearFlag = true;

		}
	}

	bool checkDistanceWithGlass(float goalPosition, float glassPosition) {

		if (clearFlag == false) {
			distance = glassPosition - goalPosition;

			if (distance < xSize / 2) {
					return true;
			}
		}
		return false;
	}
}


