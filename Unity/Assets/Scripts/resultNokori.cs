using UnityEngine;
using System.Collections;

public class resultNokori: MonoBehaviour {

	public string Text;
	public int depth =0;
	public float strWidth=4;
	public float strLeft=50;
	public float strTop=40;
	private float time;
	public GUIStyle style;
	
	// Use this for initialization
	void Start()
	{
		GUI.depth = depth;
		Text="  残量       " + (int)(((float)Player.waterLife/22)*100) + "%";
	}
	
	// Update is called once per frame
	void Update()
	{
	}
	
	void OnGUI()
	{

			style.fontSize = (int)(Screen.width * strWidth / 100);
			GUILayout.BeginArea(new Rect(Screen.width * strLeft / 100, Screen.height * strTop / 100,
			                             style.CalcSize(new GUIContent(Text)).x, style.CalcSize(new GUIContent(Text)).y));
			
			GUILayout.Label(Text, style);
			GUILayout.EndArea();
			
			
	}
	
}
