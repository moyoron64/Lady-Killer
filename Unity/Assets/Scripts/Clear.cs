using UnityEngine;
using System.Collections;

public class Clear : MonoBehaviour {
	Animation _anim;
	private float time = 0.0f;

	// Use this for initialization

	void Start () {
		animation.Stop("clear");

		animation.Stop("Clear 1");

		animation.Stop("Clear");

	


	}
	
	// Update is called once per frame
	void Update () {

		time = animation[animation.clip.name].time;
		animation.Stop();


	
	}


}
