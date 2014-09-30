using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	GUILayer guiLayer;
	GameObject n0;
	GameObject n1;
	GameObject n2;
	GameObject n3;
	GameObject n4;
	GameObject n5;
	GameObject n6;
	GameObject n7;
	GameObject n8;
	GameObject n9;
	GameObject n10;
	GameObject n11;
	GameObject n12;
	GameObject n13;
	GameObject n14;
	GameObject n15;
	GameObject n16;
	GameObject n17;
	GameObject n18;
	GameObject n19;
	public static float timer = 0;
	int number10;
	int number;
	

	// Use this for initialization
	void Start () {
		
		
		
		
		guiLayer = Camera.main.GetComponent<GUILayer>();
		
		n0 = GameObject.Find("00");
		n1 = GameObject.Find("01");
		n2 = GameObject.Find("02");
		n3 = GameObject.Find("03");
		n4 = GameObject.Find("04");
		n5 = GameObject.Find("05");
		n6 = GameObject.Find("06");
		n7 = GameObject.Find("07");
		n8 = GameObject.Find("08");
		n9 = GameObject.Find("09");
		n10 = GameObject.Find("10");
		n11 = GameObject.Find("11");
		n12 = GameObject.Find("12");
		n13 = GameObject.Find("13");
		n14 = GameObject.Find("14");
		n15 = GameObject.Find("15");
		n16 = GameObject.Find("16");
		n17 = GameObject.Find("17");
		n18 = GameObject.Find("18");
		n19 = GameObject.Find("19");

	
		
		n0.renderer.enabled = false;
		n1.renderer.enabled = false;
		n2.renderer.enabled = false;
		n3.renderer.enabled = false;
		n4.renderer.enabled = false;
		n5.renderer.enabled = false;
		n6.renderer.enabled = false;
		n7.renderer.enabled = false;
		n8.renderer.enabled = false;
		n9.renderer.enabled = false;
		n10.renderer.enabled = false;
		n11.renderer.enabled = false;
		n12.renderer.enabled = false;
		n13.renderer.enabled = false;
		n14.renderer.enabled = false;
		n15.renderer.enabled = false;
		n16.renderer.enabled = false;
		n17.renderer.enabled = false;
		n18.renderer.enabled = false;
		n19.renderer.enabled = false;

		timer = 60;
		
	}
	
	// Update is called once per frame
	void Update () {

		if(((Goal.clearFlag == false) || (Player.failedFlag == false)) && (readyGo.startFlag == true))timer -= Time.deltaTime;
		number10 = (int)(timer/10);
		number = (int)(timer%10);


		n0.renderer.enabled = false;
		n1.renderer.enabled = false;
		n2.renderer.enabled = false;
		n3.renderer.enabled = false;
		n4.renderer.enabled = false;
		n5.renderer.enabled = false;
		n6.renderer.enabled = false;
		n7.renderer.enabled = false;
		n8.renderer.enabled = false;
		n9.renderer.enabled = false;
		n10.renderer.enabled = false;
		n11.renderer.enabled = false;
		n12.renderer.enabled = false;
		n13.renderer.enabled = false;
		n14.renderer.enabled = false;
		n15.renderer.enabled = false;
		n16.renderer.enabled = false;
		n17.renderer.enabled = false;
		n18.renderer.enabled = false;
		n19.renderer.enabled = false;

		if (number10 ==9 )n19.renderer.enabled = true;
		if (number10 ==8 )n18.renderer.enabled = true;
		if (number10 ==7 )n17.renderer.enabled = true;
		if (number10 ==6 )n16.renderer.enabled = true;
		if (number10 ==5 )n15.renderer.enabled = true;
		if (number10 ==4 )n14.renderer.enabled = true;
		if (number10 ==3 )n13.renderer.enabled = true;
		if (number10 ==2 )n12.renderer.enabled = true;
		if (number10 ==1 )n11.renderer.enabled = true;
		if (number10 ==0 )n10.renderer.enabled = true;

		if (number ==9 )n9.renderer.enabled = true;
		if (number ==8 )n8.renderer.enabled = true;
		if (number ==7 )n7.renderer.enabled = true;
		if (number ==6 )n6.renderer.enabled = true;
		if (number ==5 )n5.renderer.enabled = true;
		if (number ==4 )n4.renderer.enabled = true;
		if (number ==3 )n3.renderer.enabled = true;
		if (number ==2 )n2.renderer.enabled = true;
		if (number ==1 )n1.renderer.enabled = true;
		if (number ==0 )n0.renderer.enabled = true;



		
	
	}
}
