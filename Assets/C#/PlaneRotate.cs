using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneRotate : MonoBehaviour {
	public GameObject Plane;
	//public Rigidbody rd;
	//public float Sportspeed2 = 5;
	public float Rotatespeed = 2;
	//public GameObject camera;
	private GameObject plane;
	Quaternion qua;

	// Use this for initialization
	void Start()
	{
		plane = GameObject.Find("StarSparrow1");
	}

	// Update is called once per frame
	void Update()
	{
		
        if (Input.GetKey(KeyCode.Mouse2)) {
		float X = Input.GetAxis("Mouse X") * Rotatespeed;
		float Y = Input.GetAxis("Mouse Y") * Rotatespeed;
			/*camera.transform.RotateAround(Plane.transform.position, Vector3.up, X* 5);
			camera.transform.RotateAround(Plane.transform.position, transform.right, -Y * 5);
			qua = camera.transform.rotation;
			qua.z = 0;
			camera.transform.rotation = qua;*/

			//camera.transform.Rotate(X, Y, 0);
			Plane.transform.localRotation = Plane.transform.localRotation * Quaternion.Euler(-Y*3, 0, 0);
			transform.localRotation = transform.localRotation * Quaternion.Euler(0, X*3, 0);
		}
	}
}
