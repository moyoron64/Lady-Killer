using UnityEngine;
using System.Collections;

public class Black : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GameObject	myCube = GameObject.Find("Cube");


		myCube.renderer.material.color =new Color(1f,1f, 1f, 0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
