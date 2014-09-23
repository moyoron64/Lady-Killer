﻿using UnityEngine;
using System.Collections;

public class CameraControll : MonoBehaviour {

	private GameObject kakuteru = null;
	private GameObject goalPosition = null;

	public Vector3 offset;

	// Use this for initialization
	void Start () {
		this.kakuteru = GameObject.FindGameObjectWithTag("kakuteru");
		this.goalPosition = GameObject.FindGameObjectWithTag("ok");

		this.offset = this.transform.position - this.kakuteru.transform.position;

	}

	// Update is called once per frame
	void Update () {
		if(this.transform.position.x < this.goalPosition.transform.position.x )return;

		this.transform.position = new Vector3(this.transform.position.x, this.kakuteru.transform.position.y + 3, this.kakuteru.transform.position.z + this.offset.z);
	
		if ((this.transform.position.x - this.kakuteru.transform.position.x) >= -3) {
			this.transform.position = new Vector3(this.kakuteru.transform.position.x - 3, this.kakuteru.transform.position.y + 3, this.kakuteru.transform.position.z + this.offset.z);
		}
	}
}
