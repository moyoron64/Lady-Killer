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
		this.transform.position = new Vector3 (this.kakuteru.transform.position.x + suraid - 5f, this.transform.position.y, this.transform.position.z);


	}

	// Update is called once per frame
	void Update () {

		if(this.pCamera.transform.position.x < this.ok.transform.position.x )return;
		if ((this.kakuteru.transform.position.x - this.pCamera.transform.position.x  ) >3)return;
		if (readyGo.startFlag == false)return;


		//if ((this.kakuteru.transform.position.x - this.pCamera.transform.position.x  ) >=3   && bPlayer - Player.xPosition > 0.01f) {
			//this.transform.position = new Vector3 (this.kakuteru.transform.position.x + suraid - 5f, this.transform.position.y, this.transform.position.z);
			suraid += 0.03f;
			this.transform.position = new Vector3 (this.kakuteru.transform.position.x + suraid -5f , this.transform.position.y, this.transform.position.z);
			bPlayer = Player.xPosition;
		//}
		 
		

	    /*

		if (sabun < -0.1f) {

			sabun = 0;
		}

		if (sabun > 0) {
			sabun = 0;
		}
		*/

		//Debug.Log ("sabun="+ sabun);

	}
}
