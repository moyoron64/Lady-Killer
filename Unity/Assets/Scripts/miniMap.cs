using UnityEngine;
using System.Collections;

public class miniMap : MonoBehaviour {
	public GameObject glass;
	public GameObject goal;
	public GameObject miniBar;
	public GameObject miniGlass;

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
		offset = transform.position - glass.transform.position;
	}

	// Update is called once per frame
	void Update () {
		currentDistance =  glass.transform.localPosition.x - goal.transform.localPosition.x;

		// グラスとゴールとの距離比率
		float perce = currentDistance/startDistance;


		transform.position = new Vector3(glass.transform.position.x + 4, glass.transform.position.y + 7 ,glass.transform.position.z + offset.z);
		miniGlass.transform.position = new Vector3(glass.transform.position.x + (perce * transform.lossyScale.x), glass.transform.position.y + 7.7f ,glass.transform.position.z + offset.z);
	}
}
