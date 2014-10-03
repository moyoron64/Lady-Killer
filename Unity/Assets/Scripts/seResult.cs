using UnityEngine;
using System.Collections;

public class seResult : MonoBehaviour {

	public float startTime;
	private float currentTime;
	int score;
	int rank,fine;
	public bool seOk;
	// Use this for initialization
	void Start () {
		rank = 0;
		seOk = true;
		currentTime = startTime;

		switch(Application.loadedLevelName) {
		case "Result1":
			fine = 0;
			break;
		case "Result2":
			fine = 2;
			break;
		case "Result3":
			fine = 5;
			break;
		case "Result4":
			fine = 6;
			break;
		case "Result5":
			fine = 10;
			break;
		case "Result6":
			fine = 7;
			break;
		case "Result7":
			fine = 15;
			break;
		case "Result8":
			fine = 20;
			break;
		default :
			fine = 0;
			break;
		}
		
		
		score = (int)( (3333333*Timer.timer/(60 - fine))  +  (3333333 * (float)Player.waterLife/22) + (3333333 * ((9-System.Math.Abs(Goal.distance) )/ 9)) );		
		
		if(score>8500000)rank = 3;
		if(score>7000000 && score <=8500000 )rank = 0;
		if(score >5000000 &&  score <=7000000)rank = 1;
		if(score <5000000)rank = 2;
		
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
		currentTime -= Time.deltaTime;


		if (currentTime <= 0 && seOk == true) { 
			SoundManager.Instance.PlaySE (rank);
			seOk = false;
		}



	}
}
