﻿using UnityEngine;
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
	float glassStartPosition;

	// Use this for initialization
	void Start () {
		miniBar = GameObject.Find("miniMapBar");
		miniGlass = GameObject.Find("miniMapGlass");


		glass = GameObject.Find("glass-kara");
		goal = GameObject.Find("Goal");

		glassStartPosition = glass.transform.localPosition.x;
		startDistance = glass.transform.localPosition.x - goal.transform.localPosition.x;

		// カメラに追従させる
	}

	// Update is called once per frame
	void Update () {
		currentDistance =  glass.transform.localPosition.x - goal.transform.localPosition.x;

		// グラスとゴールとの距離比率
		float perce = currentDistance/startDistance;
		float barWidth = miniBar.renderer.bounds.size.x;

		if (isOnBar(barWidth) && glass.transform.localPosition.x < glassStartPosition + 0.03){
			miniGlass.transform.position = new Vector3(transform.position.x + barWidth/2 - 0.22f - ((1-perce) * barWidth), transform.position.y - 0.13f, 0);
		}
	}

	public bool isOnBar(float barWidth)
	{
		if (miniGlass.transform.localPosition.x - 0.22f < transform.localPosition.x - barWidth/2) {
			return false;
		}

		/*
		if (miniGlass.transform.localPosition.x + 0.22f > transform.localPosition.x + barWidth/2) {
			return false;
		}
		*/

		if (transform.localPosition.x + barWidth/2 < miniGlass.transform.localPosition.x) {
			return false;
		}

		return true;
	}
}
