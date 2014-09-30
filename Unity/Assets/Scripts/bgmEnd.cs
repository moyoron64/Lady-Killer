using UnityEngine;
using System.Collections;

public class bgmEnd : MonoBehaviour {

	public float endTime;
	private float currentTime;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		endTime -= Time.deltaTime;
		
		if (endTime <= 0f)
		{
			SoundManager.Instance.StopBGM ();
		}

				
		


	}
}
