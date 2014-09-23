using UnityEngine;
using System.Collections;

public class resultTime : MonoBehaviour {


	public string Text;
	public int depth =0;
	public float strWidth=4;
	public float strLeft=50;
	public float strTop=20;
	private float time;
	public GUIStyle style;
	
	// Use this for initialization
	void Start()
	{
		GUI.depth = depth;
		Text="残り時間    " + (int)Timer.timer +"秒";
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
