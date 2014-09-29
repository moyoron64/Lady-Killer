using UnityEngine;
using System.Collections;

public class seSound : MonoBehaviour {

	public float startTime;
	public string seNumber;
	private float currentTime;
	// Use this for initialization
	void Start () {

		currentTime = startTime;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		currentTime -= Time.deltaTime;
		


	}
}
