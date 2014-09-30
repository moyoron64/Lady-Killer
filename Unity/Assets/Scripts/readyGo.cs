using UnityEngine;
using System.Collections;

public class readyGo : MonoBehaviour {

	public static bool startFlag;
	private bool seFlag;
	private bool seFlag2;
	public float startTime = 2f;
	void Start () {
		startFlag = false;
		seFlag2 = true;

		seFlag = true;
	}


	// Update is called once per frame
	void Update () {
	
		if (startTime < 2 && seFlag == true) {
			SoundManager.Instance.PlaySE(18);
			seFlag =false;
		}


		if ( startTime <= 1.7f &&seFlag2== true) {
			SoundManager.Instance.PlaySE(14);
			startFlag = true;
			seFlag2=false;
			return;
		}

		if ( startTime <= 0) {
			startFlag = true;
			return;
		}

	}
}
