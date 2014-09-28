using UnityEngine;
using System.Collections;

public class jumpCheck : MonoBehaviour {

	float time;
	private bool timeBool;

	void Start () {
		time = 0;
		timeBool = false;
	}

	void Update () {


		if (timeBool == true) {
			time -= Time.deltaTime;
			if(time <0)jumpOk();
		}

	}

	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("yuka")){ //ジャンプで当たった

			time = 0.05f;
			timeBool = true;

		}
	}

	void jumpOk(){
		Player.jump = false;
		Player.isGrounded = true;
		timeBool = false;
	}
}
