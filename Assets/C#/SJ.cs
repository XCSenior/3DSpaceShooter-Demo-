using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SJ : MonoBehaviour {
	public GameObject obj;
	private double n = 500;
	// Use this for initialization
	void Start () {
		for(int i = 0; i < n; i++)
        {

			Instantiate(obj, new Vector3(Random.Range(-1000f, 1000f), Random.Range(-1000f, 1000f),
				Random.Range(-1000f, 1000f)), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
