using UnityEngine;
using System.Collections;

public class seSound : MonoBehaviour {

	public float startTime;
	public int seNumber;
	private float currentTime;
	public bool seOk;
	// Use this for initialization
	void Start () {

		currentTime = startTime;
		seOk = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		currentTime -= Time.deltaTime;
		if (currentTime <= 0 && seOk == true) { 
						
			seOk = false;
			SoundManager.Instance.PlaySE (seNumber);
				
		}


	}
}
