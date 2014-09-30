using UnityEngine;
using System.Collections;

public class TotalFade : MonoBehaviour {
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

		score = PlayerPrefs.GetInt("sumScore");
		
		
		


	}
	
	// Update is called once per frame
	void Update () {



		if(score>70000000)AS.renderer.enabled = true;
		if(score>55000000 && score <=70000000 )AA.renderer.enabled = true;
		if(score >=40000000 &&  score <=55000000)AB.renderer.enabled = true;
		if(score < 40000000)AC.renderer.enabled = true;



	
	}
}
