using UnityEngine;
using System.Collections;

public class bgmSound : MonoBehaviour {

	public float startTime;
	public int seNumber;
	private float currentTime;
	// Use this for initialization
	void Start () {

		currentTime = startTime;
		SoundManager.Instance.PlayBGM (seNumber);
	}
	
	// Update is called once per frame
	void Update () {


				
		


	}
}
