using UnityEngine;
using System.Collections;

public class xKotei : MonoBehaviour {

	float startPosition;

	// Use this for initialization
	void Start () {

		startPosition = transform.localPosition.x;
	
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.position = new Vector3 (startPosition, this.transform.position.y , this.transform.position.z );
		


	}
}
