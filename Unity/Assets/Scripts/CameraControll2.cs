﻿using UnityEngine;
using System.Collections;

public class CameraControll2 : MonoBehaviour {

	private GameObject kakuteru = null;
	private GameObject goalPosition = null;

	public Vector3 offset;
	public static float xCameraPosition;
	public float bottom = 8;
	private float firstYKakuteru;

	// Use this for initialization
	void Start () {
		this.kakuteru = GameObject.FindGameObjectWithTag("stage");
		this.goalPosition = GameObject.FindGameObjectWithTag("ok");
		firstYKakuteru = this.kakuteru.transform.position.y;
		this.offset = this.transform.position - this.kakuteru.transform.position;



	}

	// Update is called once per frame
	void Update () {



		xCameraPosition = this.transform.position.x;

		if(this.transform.position.x < this.goalPosition.transform.position.x )return;




			this.transform.position = new Vector3(this.kakuteru.transform.position.x-3, this.kakuteru.transform.position.y+4, this.kakuteru.transform.position.z + this.offset.z);
			
		/*
			if ((this.transform.position.x - this.kakuteru.transform.position.x) >= -3  ) {
				this.transform.position = new Vector3 (this.kakuteru.transform.position.x - 3, this.transform.position.y , this.kakuteru.transform.position.z + this.offset.z);
			}

		*/	






	}
}
