using UnityEngine;
using System.Collections;

public class miniMap : MonoBehaviour {
	public static GameObject glass;
	public static GameObject goal;
	public static GameObject miniBar;
	public static GameObject miniGlass;
	public float miniGlassPosition;

	public Vector3 offset;


	float startDistance; // グラスとゴールの最初の距離
	float currentDistance; // 現在のグラスとゴールとの距離

	// Use this for initialization
	void Start () {
		miniBar = GameObject.Find("miniMapBar");
		miniGlass = GameObject.Find("miniMapGlass");


		glass = GameObject.Find("glass-kara");
		goal = GameObject.Find("Goal");

		startDistance = glass.transform.localPosition.x - goal.transform.localPosition.x;

		// カメラに追従させる
	}

	// Update is called once per frame
	void Update () {
		currentDistance =  glass.transform.localPosition.x - goal.transform.localPosition.x;

		// グラスとゴールとの距離比率
		float perce = currentDistance/startDistance;
		float barWidth = miniBar.renderer.bounds.size.x;

		miniGlass.transform.position = new Vector3(transform.position.x + barWidth/2 - ((1-perce) * barWidth), transform.position.y, 0);
//		miniGlass.transform.position = new Vector3(glass.transform.position.x + (perce * transform.lossyScale.x)-0.8f, glass.transform.position.y + 7.7f ,glass.transform.position.z + offset.z);
		//miniGlass.transform.position = new Vector3(glass.transform.position.x + (perce * transform.lossyScale.x), transform.position.y + 0.1f,glass.transform.position.z + offset.z);
		//miniGlass.transform.position = new Vector3(transform.localPosition.x + 22.0f, transform.position.y + 0.1f,glass.transform.position.z + offset.z);



	}
}
