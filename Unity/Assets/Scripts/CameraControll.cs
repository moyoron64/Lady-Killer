﻿using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {

	private GameObject kakuteru = null;
	private GameObject goalPosition = null;
	private GameObject stage = null;

	public Vector3 offset;
	public static float xCameraPosition;
	public float bottom = 8;
	private float firstYKakuteru;
	private bool jumpCheck;
	// Use this for initialization
	void Start () {
		this.kakuteru = GameObject.FindGameObjectWithTag("kakuteru");
		this.goalPosition = GameObject.FindGameObjectWithTag("ok");
		this.stage  = GameObject.FindGameObjectWithTag("stage");
		firstYKakuteru = this.kakuteru.transform.position.y;
		this.offset = this.transform.position - this.kakuteru.transform.position;
		jumpCheck = false;



	}

	// Update is called once per frame
	void Update () {



		xCameraPosition = this.transform.position.x;

		if(this.transform.position.x < this.goalPosition.transform.position.x )return;

		if ( Player.jump == false || this.transform.position.y > this.kakuteru.transform.position.y +3 ) {

			float check = this.transform.position.x - this.kakuteru.transform.position.x;


			if(jumpCheck == true ) {
				if( this.transform.position.y > this.kakuteru.transform.position.y +3 )jumpCheck= false;
				if (this.transform.position.y > this.stage.transform.position.y ) jumpCheck = false;
				if(check < -3.13 )jumpCheck = false;
				if(this.transform.position.y < firstYKakuteru - 0.15f )jumpCheck=false;

				if (jumpCheck == true){
				transform.position = new Vector3(this.kakuteru.transform.position.x-3,  this.transform.position.y+0.123f,this.kakuteru.transform.position.z + this.offset.z);
				

					return;
				}
			}


			if(this.transform.position.y >= firstYKakuteru - 0.15f )this.transform.position = new Vector3(this.transform.position.x, this.kakuteru.transform.position.y + 3, this.kakuteru.transform.position.z + this.offset.z);
	

			if ((this.transform.position.x - this.kakuteru.transform.position.x) >= -3  && this.transform.position.y >= firstYKakuteru - 0.15f) {
					this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.kakuteru.transform.position.y + 3, this.kakuteru.transform.position.z + this.offset.z);
			}

			if (this.transform.position.y < firstYKakuteru - 0.15f) {
				this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
				
			}



		}

		if (Player.jump == true && this.transform.position.y < this.kakuteru.transform.position.y +3 ) {

			jumpCheck = true;

			this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.kakuteru.transform.position.z + this.offset.z);
			

			if ((this.transform.position.x - this.kakuteru.transform.position.x) >= -3  && this.transform.position.y >= firstYKakuteru - 0.15f) {
				this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
			}

			if (this.transform.position.y < firstYKakuteru - 0.15f) {
				this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
				
			}

		}

		if (this.transform.position.y > this.stage.transform.position.y ){
			this.transform.position = new Vector3 (this.transform.position.x, this.stage.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
		}

		if (this.transform.position.y > this.stage.transform.position.y && (this.transform.position.x - this.kakuteru.transform.position.x) >= -3 ){
			this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.stage.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
		}






	}
}
