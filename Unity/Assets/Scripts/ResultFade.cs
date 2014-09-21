using UnityEngine;
using System.Collections;

public class ResultFade : MonoBehaviour {
	GameObject AA,AB,AC,AS;
	GameObject CA,CB,CC,CS;
	int score;

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
	





	}
	
	// Update is called once per frame
	void Update () {
		score = (int)(3333333*Timer.timer/60+  3333333 * (float)Player.waterLife/22 + 3333333 * Goal.distance /3);

		if(score>9000000)CS.renderer.enabled = true;
		if(score>7000000 && score <=9000000 )CA.renderer.enabled = true;
		if(score >5000000 &&  score <=7000000)CB.renderer.enabled = true;
		if(score <5000000)CC.renderer.enabled = true;


		if(score>9000000)AS.renderer.enabled = true;
		if(score>7000000 && score <=9000000 )AA.renderer.enabled = true;
		if(score >=5000000 &&  score <=7000000)AB.renderer.enabled = true;
		if(score < 5000000)AC.renderer.enabled = true;

		Debug.Log (score);



	
	}
}
