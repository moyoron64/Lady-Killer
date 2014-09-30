using UnityEngine;
using System.Collections;

public class seTotalResult : MonoBehaviour {

	public float startTime;
	private float currentTime;
	int score;
	int rank;
	public bool seOk;
	// Use this for initialization
	void Start () {
		rank = 0;
		seOk = true;
		currentTime = startTime;

		score = PlayerPrefs.GetInt("sumScore");
		
		
		
		if(score>70000000)rank = 3;
		if(score>55000000 && score <=70000000 )rank = 0;
		if(score >=40000000 &&  score <=55000000)rank = 1;
		if(score < 40000000)rank = 2;
		
		
		
		if(score>9000000)rank = 3;
		if(score>7000000 && score <=9000000 )rank = 0;
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
