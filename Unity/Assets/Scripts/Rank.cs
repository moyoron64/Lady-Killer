using UnityEngine;
using System.Collections;

public class Rank : MonoBehaviour {
	GameObject TA,TB,TC,TS,NA,NB,NC,NS,KA,KB,KC,KS,AA,AB,AC,AS;
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






	}
	
	// Update is called once per frame
	void Update () {

		float kyori = System.Math.Abs(Goal.distance);


		if(Timer.timer>50)TS.renderer.enabled = true;
		if(Timer.timer>40 && Timer.timer <=50 )TA.renderer.enabled = true;
		if(Timer.timer >30 &&  Timer.timer <=40)TB.renderer.enabled = true;
		if(Timer.timer <=30)TC.renderer.enabled = true;

		if(kyori>2)KC.renderer.enabled = true;
		if(kyori>1 && kyori <=2 )KB.renderer.enabled = true;
		if(kyori >0.5 &&  kyori <=1)KA.renderer.enabled = true;
		if(kyori <=0.5)KS.renderer.enabled = true;

		if(Player.waterLife>21)NS.renderer.enabled = true;
		if(Player.waterLife>16 && Player.waterLife <=21 )NA.renderer.enabled = true;
		if(Player.waterLife >8 &&  Player.waterLife <=16)NB.renderer.enabled = true;
		if(Player.waterLife <=8)NC.renderer.enabled = true;

	
	}
}
