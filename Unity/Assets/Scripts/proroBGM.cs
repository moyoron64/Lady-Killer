using UnityEngine;
using System.Collections;

public class proroBGM : MonoBehaviour {
	public int Count;
	public float imaTime;
	// Use this for initialization
	void Start () {
		Count = 0;
		SoundManager.Instance.PlayBGM (4);
		imaTime = 24;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.touchCount == 1) {
			
						Touch touch = Input.GetTouch (0);
			
						if (touch.phase != TouchPhase.Began)return;

						Count++;
						if(Count ==2)SoundManager.Instance.StopBGM();
						
		}
		imaTime -= Time.deltaTime;
		if(imaTime <= 0)SoundManager.Instance.StopBGM();

	}
}
