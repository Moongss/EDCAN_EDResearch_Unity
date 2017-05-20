using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	public Rigidbody my_rb;
	public float speed = 0.5f;
	public float jumpForce = 1f;
	// Use this for initialization
	void Start () {
		my_rb = this.gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			this.gameObject.transform.Translate (new Vector3 (-speed, 0, 0));
		}
		if (Input.GetKey(KeyCode.D)) {
			this.gameObject.transform.Translate (new Vector3 (speed, 0, 0));
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			my_rb.AddForce (new Vector3 (0, jumpForce, 0));
		}
	}
}
