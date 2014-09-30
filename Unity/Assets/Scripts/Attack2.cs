using UnityEngine;
using System.Collections;

public class Attack2 : MonoBehaviour {
	
	float time;
	public static float xRole; 
	public static  bool attackBool;
	
	void Start () {
	}
	
	void Update () {
		
		
		
	}
	
	void OnTriggerEnter2D(Collider2D collider){
		if((collider.CompareTag("yuka") || collider.CompareTag("slip"))&& (Player.myXRole > 350 || Player.myXRole < 10)){ //ジャンプで当たった
			SoundManager.Instance.PlaySE (10);	
			
		}
	}
	

}
