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

		AA = GameObject.Find("AA");
		AB = GameObject.Find("AB");
		AC = GameObject.Find("AC");
		AS = GameObject.Find("AS");

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

		AA.renderer.enabled = false;
		AB.renderer.enabled = false;
		AC.renderer.enabled = false;
		AS.renderer.enabled = false;




	}
	
	// Update is called once per frame
	void Update () {

		/*
			if(time>)TS.renderer.enabled = true;
			if(time> && time <= )TA.renderer.enabled = true;
			if(time > &&  time <=)TB.renderer.enabled = true;
			if(time <=)TC.renderer.enabled = true;
		*/
	
	}
}
