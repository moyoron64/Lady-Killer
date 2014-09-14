using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	GUILayer guiLayer;
	GUITexture n0;
	GUITexture n1;
	GUITexture n2;
	GUITexture n3;
	GUITexture n4;
	GUITexture n5;
	GUITexture n6;
	GUITexture n7;
	GUITexture n8;
	GUITexture n9;
	GUITexture n10;
	GUITexture n11;
	GUITexture n12;
	GUITexture n13;
	GUITexture n14;
	GUITexture n15;
	GUITexture n16;
	GUITexture n17;
	GUITexture n18;
	GUITexture n19;
	public static float timer;
	public bool paused = true;
	int number10;
	int number;
	

	// Use this for initialization
	void Start () {
		
		
		
		
		guiLayer = Camera.main.GetComponent<GUILayer>();
		
		GameObject go0 = GameObject.Find("0");
		GameObject go1 = GameObject.Find("1");
		GameObject go2 = GameObject.Find("2");
		GameObject go3 = GameObject.Find("3");
		GameObject go4 = GameObject.Find("4");
		GameObject go5 = GameObject.Find("5");
		GameObject go6 = GameObject.Find("6");
		GameObject go7 = GameObject.Find("7");
		GameObject go8 = GameObject.Find("8");
		GameObject go9 = GameObject.Find("9");
		GameObject go10 = GameObject.Find("10");
		GameObject go11 = GameObject.Find("11");
		GameObject go12 = GameObject.Find("12");
		GameObject go13 = GameObject.Find("13");
		GameObject go14 = GameObject.Find("14");
		GameObject go15 = GameObject.Find("15");
		GameObject go16 = GameObject.Find("16");
		GameObject go17 = GameObject.Find("17");
		GameObject go18 = GameObject.Find("18");
		GameObject go19 = GameObject.Find("19");

		n0 = (GUITexture)go0.GetComponent(typeof(GUITexture));
		n1 = (GUITexture)go1.GetComponent(typeof(GUITexture));
		n2 = (GUITexture)go2.GetComponent(typeof(GUITexture));
		n3 = (GUITexture)go3.GetComponent(typeof(GUITexture));
		n4 = (GUITexture)go4.GetComponent(typeof(GUITexture));
		n5 = (GUITexture)go5.GetComponent(typeof(GUITexture));
		n6 = (GUITexture)go6.GetComponent(typeof(GUITexture));
		n7 = (GUITexture)go7.GetComponent(typeof(GUITexture));
		n8 = (GUITexture)go8.GetComponent(typeof(GUITexture));
		n9 = (GUITexture)go9.GetComponent(typeof(GUITexture));
		n10 = (GUITexture)go10.GetComponent(typeof(GUITexture));
		n11 = (GUITexture)go11.GetComponent(typeof(GUITexture));
		n12 = (GUITexture)go12.GetComponent(typeof(GUITexture));
		n13 = (GUITexture)go13.GetComponent(typeof(GUITexture));
		n14 = (GUITexture)go14.GetComponent(typeof(GUITexture));
		n15 = (GUITexture)go15.GetComponent(typeof(GUITexture));
		n16 = (GUITexture)go16.GetComponent(typeof(GUITexture));
		n17 = (GUITexture)go17.GetComponent(typeof(GUITexture));
		n18 = (GUITexture)go18.GetComponent(typeof(GUITexture));
		n19 = (GUITexture)go19.GetComponent(typeof(GUITexture));

		
		
		n0.guiTexture.enabled = false;
		n1.guiTexture.enabled = false;
		n2.guiTexture.enabled = false;
		n3.guiTexture.enabled = false;
		n4.guiTexture.enabled = false;
		n5.guiTexture.enabled = false;
		n6.guiTexture.enabled = false;
		n7.guiTexture.enabled = false;
		n8.guiTexture.enabled = false;
		n9.guiTexture.enabled = false;
		n10.guiTexture.enabled = false;
		n11.guiTexture.enabled = false;
		n12.guiTexture.enabled = false;
		n13.guiTexture.enabled = false;
		n14.guiTexture.enabled = false;
		n15.guiTexture.enabled = false;
		n16.guiTexture.enabled = false;
		n17.guiTexture.enabled = false;
		n18.guiTexture.enabled = false;
		n19.guiTexture.enabled = false;

		timer = 99;
		
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;
		number10 = (int)(timer/10);
		number = (int)(timer%10);


		n0.guiTexture.enabled = false;
		n1.guiTexture.enabled = false;
		n2.guiTexture.enabled = false;
		n3.guiTexture.enabled = false;
		n4.guiTexture.enabled = false;
		n5.guiTexture.enabled = false;
		n6.guiTexture.enabled = false;
		n7.guiTexture.enabled = false;
		n8.guiTexture.enabled = false;
		n9.guiTexture.enabled = false;
		n10.guiTexture.enabled = false;
		n11.guiTexture.enabled = false;
		n12.guiTexture.enabled = false;
		n13.guiTexture.enabled = false;
		n14.guiTexture.enabled = false;
		n15.guiTexture.enabled = false;
		n16.guiTexture.enabled = false;
		n17.guiTexture.enabled = false;
		n18.guiTexture.enabled = false;
		n19.guiTexture.enabled = false;

		if (number10 ==9 )n19.guiTexture.enabled = true;
		if (number10 ==8 )n18.guiTexture.enabled = true;
		if (number10 ==7 )n17.guiTexture.enabled = true;
		if (number10 ==6 )n16.guiTexture.enabled = true;
		if (number10 ==5 )n15.guiTexture.enabled = true;
		if (number10 ==4 )n14.guiTexture.enabled = true;
		if (number10 ==3 )n13.guiTexture.enabled = true;
		if (number10 ==2 )n12.guiTexture.enabled = true;
		if (number10 ==1 )n11.guiTexture.enabled = true;
		if (number10 ==0 )n10.guiTexture.enabled = true;

		if (number ==9 )n9.guiTexture.enabled = true;
		if (number ==8 )n8.guiTexture.enabled = true;
		if (number ==7 )n7.guiTexture.enabled = true;
		if (number ==6 )n6.guiTexture.enabled = true;
		if (number ==5 )n5.guiTexture.enabled = true;
		if (number ==4 )n4.guiTexture.enabled = true;
		if (number ==3 )n3.guiTexture.enabled = true;
		if (number ==2 )n2.guiTexture.enabled = true;
		if (number ==1 )n1.guiTexture.enabled = true;
		if (number ==0 )n0.guiTexture.enabled = true;

		Debug.Log (timer);


		
	
	}
}
