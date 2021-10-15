using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {
	//public GameObject Camera;
	//public Rigidbody rd;
	public float Sportspeed2 = 5;
	public float Rotatespeed=2;

	private Camera camera;
	
	// Use this for initialization
	void Start () {
		camera = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		/*float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		Vector3 speed = new Vector3(h, 0, v);
		rd.velocity = speed * Sportspeed2;*/
		if (Input.GetKey(KeyCode.Mouse1)) {
			float X = Input.GetAxis("Mouse X") * Rotatespeed;
		float Y = Input.GetAxis("Mouse Y") * Rotatespeed;
		camera.transform.localRotation = camera.transform.localRotation * Quaternion.Euler(-Y*3, 0, 0);
		transform.localRotation = transform.localRotation * Quaternion.Euler(0, X*3, 0);
	}
}
 }