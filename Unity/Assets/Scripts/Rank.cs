using UnityEngine;
using System.Collections;

public class Rank : MonoBehaviour {
	GameObject TA,TB,TC,TS,NA,NB,NC,NS,KA,KB,KC,KS,AA,AB,AC,AS;
	private int fine;
	// Use this for initialization
	void Start () {

		TA = GameObject.Find("TA");
		TB = GameObject.Find("TB");
		TC = GameObject.Find("TC");
		TS = GameObject.Find("TS");

		KA = GameObject.Find("KA");
		KB = GameObject.Find("KB");
		KC = GameObject.Find("KC");
		KS = GameObject.Find("KS");

		NA = GameObject.Find("NA");
		NB = GameObject.Find("NB");
		NC = GameObject.Find("NC");
		NS = GameObject.Find("NS");


		TA.renderer.enabled = false;
		TB.renderer.enabled = false;
		TC.renderer.enabled = false;
		TS.renderer.enabled = false;

		KA.renderer.enabled = false;
		KB.renderer.enabled = false;
		KC.renderer.enabled = false;
		KS.renderer.enabled = false;

		NA.renderer.enabled = false;
		NB.renderer.enabled = false;
		NC.renderer.enabled = false;
		NS.renderer.enabled = false;

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
			fine = 10;
			break;
		case "Result7":
			fine = 15;
			break;
		case "Result8":
			fine = 25;
			break;
		default :
			fine = 0;
			break;
		}





		float kyori = System.Math.Abs(Goal.distance);
		
		
		if(Timer.timer>50 - fine)TS.renderer.enabled = true;
		if(Timer.timer>40 - fine&& Timer.timer <=50 - fine)TA.renderer.enabled = true;
		if(Timer.timer >30 - fine&&  Timer.timer <=40- fine)TB.renderer.enabled = true;
		if(Timer.timer <=30- fine)TC.renderer.enabled = true;
		
		if(kyori>3)KC.renderer.enabled = true;
		if(kyori>2 && kyori <=3 )KB.renderer.enabled = true;
		if(kyori >1 &&  kyori <=2)KA.renderer.enabled = true;
		if(kyori <=1)KS.renderer.enabled = true;
		
		if(Player.waterLife>17)NS.renderer.enabled = true;
		if(Player.waterLife>12 && Player.waterLife <=17 )NA.renderer.enabled = true;
		if(Player.waterLife >8 &&  Player.waterLife <=12)NB.renderer.enabled = true;
		if(Player.waterLife <=8)NC.renderer.enabled = true;

	}
	
	// Update is called once per frame
	void Update () {



	
	}
}
