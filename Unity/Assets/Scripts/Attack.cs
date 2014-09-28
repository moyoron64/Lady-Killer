using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	
	float time;
	public static float xRole; 
	public static  bool attackBool;
	
	void Start () {
		time = 0;
		attackBool = false;
	}
	
	void Update () {
		
		
		if (attackBool == true) {
			time -= Time.deltaTime;
			if(time <0)attackBool = false;
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("yuka")){ //ジャンプで当たった
			
			time = 1f;
			attackBool = true;
			xRole = Player.myXRole;
			Debug.Log("aaaaaaaaa");
			
		}
	}
	

}
