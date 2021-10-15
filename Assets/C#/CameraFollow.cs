using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public GameObject plane;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	
	void Update()
    {
		/*this.transform.position = new Vector3(plane.transform.position .x+5, plane.transform.position.y+3,
			plane.transform.position.z-14);*/
		this.transform.position = plane.transform.forward;
    }
}
