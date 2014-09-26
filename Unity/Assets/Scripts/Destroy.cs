using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	public Camera _setCamera;
	
	//Margin
	float margin = 0.1f; //マージン(画面外に出てどれくらい離れたら消えるか)を指定
	float negativeMargin;
	float positiveMargin;
	
	void Start ()
	{
		if (_setCamera == null) {
			_setCamera = Camera.main;
		}
		
		negativeMargin = 0 - margin;
		positiveMargin = 1 + margin;
	}
	
	// Update is called once per frame
	void OnBecameInvisible() {
	
		if (this.isOutOfScreen()) {
			Destroy (gameObject);
		}
	}
	
	bool isOutOfScreen()
	{
		Vector3 positionInScreen = _setCamera.WorldToViewportPoint(transform.position);
		positionInScreen.z = transform.position.z;
		
		if (positionInScreen.x >= negativeMargin  ||  positionInScreen.x >= positiveMargin  && transform.position.x > CameraControll.xCameraPosition    )
		{
			return true;
		} else {
			return false;
		}
	}
}
