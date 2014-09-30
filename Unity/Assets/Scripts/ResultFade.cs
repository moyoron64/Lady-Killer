using UnityEngine;
using System.Collections;

public class ResultFade : MonoBehaviour {
	GameObject AA,AB,AC,AS;
	GameObject CA,CB,CC,CS;
	int score,fine;

	// Use this for initialization
	void Start () {

		AA = GameObject.Find("AA");
		AB = GameObject.Find("AB");
		AC = GameObject.Find("AC");
		AS = GameObject.Find("AS");
		
		AA.renderer.enabled = false;
		AB.renderer.enabled = false;
		AC.renderer.enabled = false;
		AS.renderer.enabled = false;

		CA = GameObject.Find("CA");
		CB = GameObject.Find("CB");
		CC = GameObject.Find("CC");
		CS = GameObject.Find("CS");
		
		CA.renderer.enabled = false;
		CB.renderer.enabled = false;
		CC.renderer.enabled = false;
		CS.renderer.enabled = false;

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
		
		
		score = (int)( (3333333*Timer.timer/60 - fine)  +  (3333333 * (float)Player.waterLife/22) + (3333333 * ((9-System.Math.Abs(Goal.distance) )/ 9)) );
	


		int sumscore =PlayerPrefs.GetInt("sumScore", 0);

		sumscore = score + sumscore;

		PlayerPrefs.SetInt("sumScore", sumscore);



	}
	
	// Update is called once per frame
	void Update () {




		if(score>8500000)CS.renderer.enabled = true;
		if(score>7000000 && score <=9000000 )CA.renderer.enabled = true;
		if(score >5000000 &&  score <=7000000)CB.renderer.enabled = true;
		if(score <5000000)CC.renderer.enabled = true;


		if(score>8500000)AS.renderer.enabled = true;
		if(score>7000000 && score <=8500000 )AA.renderer.enabled = true;
		if(score >=5000000 &&  score <=7000000)AB.renderer.enabled = true;
		if(score < 5000000)AC.renderer.enabled = true;




	
	}
}
