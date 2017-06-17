using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			this.gameObject.transform.Translate (this.gameObject.transform.forward * 0.5f);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			this.gameObject.GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 0, 1) * 2); // World Position force
			//(this.gameObject.transform.forward * 2); - LocalPosition force
		} //addforce : vector3가 주는 값 만큼의 힘을 적용
	}
}
