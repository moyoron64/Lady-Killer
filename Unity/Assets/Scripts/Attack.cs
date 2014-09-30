using UnityEngine;
using System.Collections;

public class Attack : MonoBehaviour {
	
	float time;
	public static float xRole; 
	public static  bool attackBool;
	
	void Start () {
	}
	
	void Update () {
		
		
		
	}
	
	void OnTriggerEnter2D(Collider2D collider){
		if(collider.CompareTag("yuka") || collider.CompareTag("block")){ //ジャンプで当たった
			SoundManager.Instance.PlaySE (12);			
			
		}
	}
	

}
