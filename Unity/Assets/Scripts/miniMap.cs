using UnityEngine;
using System.Collections;

public class miniMap : MonoBehaviour {
	GameObject glass;
	GameObject goal;
	GameObject miniBar;
	GameObject miniGlass;

	float startDistance; // グラスとゴールの最初の距離
	float currentDistance; // 現在のグラスとゴールとの距離

	// Use this for initialization
	void Start () {
		miniBar = GameObject.Find("miniBar");
		miniGlass = GameObject.Find("miniGlass");

		glass = GameObject.Find("glass-kara");
		goal = GameObject.Find("goal");


		startDistance = getDistance(glass, goal);
	}

	// Update is called once per frame
	void Update () {
		currentDistance = getDistance(glass, goal);
		float perce = currentDistance/startDistance;


	}

	float getDistance(GameObject glass, GameObject goal)
	{
		return glass.transform.localPosition.x - goal.transform.localPosition.x;
	}
}
