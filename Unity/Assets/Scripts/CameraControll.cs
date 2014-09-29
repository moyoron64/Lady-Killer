using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {

	private GameObject kakuteru = null;
	private GameObject goalPosition = null;
	private GameObject stage = null;

	public Vector3 offset;
	public static float xCameraPosition;
	public float bottom = 8;
	private float firstYKakuteru;

	// Use this for initialization
	void Start () {
		this.kakuteru = GameObject.FindGameObjectWithTag("kakuteru");
		this.goalPosition = GameObject.FindGameObjectWithTag("ok");
		this.stage  = GameObject.FindGameObjectWithTag("stage");
		firstYKakuteru = this.kakuteru.transform.position.y;
		this.offset = this.transform.position - this.kakuteru.transform.position;



	}

	// Update is called once per frame
	void Update () {



		xCameraPosition = this.transform.position.x;

		if(this.transform.position.x < this.goalPosition.transform.position.x )return;

		if ( Player.jump == false || this.transform.position.y > this.kakuteru.transform.position.y +3 ) {	

			if(this.transform.position.y >= firstYKakuteru - 0.15f )this.transform.position = new Vector3(this.kakuteru.transform.position.x+3, this.kakuteru.transform.position.y + 3, this.kakuteru.transform.position.z + this.offset.z);
	

			if ((this.transform.position.x - this.kakuteru.transform.position.x) >= -3  && this.transform.position.y >= firstYKakuteru - 0.15f) {
					this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.kakuteru.transform.position.y + 3, this.kakuteru.transform.position.z + this.offset.z);
			}

			if (this.transform.position.y < firstYKakuteru - 0.15f) {
				this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
				
			}



		}

		if (Player.jump == true && this.transform.position.y < this.kakuteru.transform.position.y +3 ) {
			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.kakuteru.transform.position.z + this.offset.z);
			

			if ((this.transform.position.x - this.kakuteru.transform.position.x) >= -3  && this.transform.position.y >= firstYKakuteru - 0.15f) {
				this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
			}

			if (this.transform.position.y < firstYKakuteru - 0.15f) {
				this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
				
			}

		}

		if (this.transform.position.y > this.stage.transform.position.y){
			this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.stage.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
		}




	}
}
