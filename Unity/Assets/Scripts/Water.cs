using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour {
/*--------------------------------------------------------
  初期設定
--------------------------------------------------------*/
	static bool isActive = true;
	Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = transform.localPosition;
	}

	// Update is called once per frame
	void Update () {
		// 水が地面にこぼれたときの処理
		if (transform.localPosition.y < 0.5 && isActive) {
			waterLost();
		}

		if (Player.waterLife == 0 && Player.isActive) {
			Invoke("resetStage", 3);
		}
	}

	public void waterLost()
	{
		isActive = false;
		Player.waterLife -= 1;
	}

	public void resetStage()
	{
		transform.localPosition = startPosition;
	}
}
