using UnityEngine;
using System.Collections;

public class haikeiMake : MonoBehaviour {

	private float sabun;
	private float bPlayer;
	private float suraid;
	GameObject kakuteru,pCamera,ok;
	// Use this for initialization
	void Start () {
		bPlayer = Player.xPosition+0.1f;
		sabun = 0;

		suraid = 0;
		kakuteru = GameObject.Find("glass-kara");
		pCamera = GameObject.Find("cameraPosition");
		ok = GameObject.Find("ok");
		this.transform.position = new Vector3 (this.kakuteru.transform.position.x + suraid - 20f, this.transform.position.y, this.transform.position.z);


	}

	// Update is called once per frame
	void Update () {

		if(this.pCamera.transform.position.x < this.ok.transform.position.x )return;

		if ((pCamera.transform.position.x - kakuteru.transform.position.x) >= -3) {
			sabun += Player.xPosition - bPlayer;
			this.transform.position = new Vector3 (this.kakuteru.transform.position.x + suraid - 5f, this.transform.position.y, this.transform.position.z);
			bPlayer = Player.xPosition;
		}




		if (sabun < -0.1f) {
			suraid += 0.04f;
			sabun = 0;
		}

		if (sabun > 0.2f) {
			sabun = 0;
		}


		//Debug.Log ("sabun="+ sabun);

	}
}
