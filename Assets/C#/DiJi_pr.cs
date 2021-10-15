using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiJi_pr : MonoBehaviour {

	public GameObject obj;
	private double n =1000;
	// Use this for initialization
	void Start()
	{
		for (int i = 0; i < n; i++)
		{
			GameObject game;
			 game= Instantiate(obj, new Vector3(Random.Range(-1000f, 1000f), Random.Range(-1000f, 1000f),
				Random.Range(-1000f, 1000f)), Quaternion.identity);
	//game.transform.rotation=new Vector3(Random.Range(-180, 180), Random.Range(-180, 180),
		//Random.Range(-180, 180));
			game.transform.rotation = Quaternion.Euler(new Vector3(Random.Range(-180f, 180f),
				Random.Range(-180f, 180f), Random.Range(-180f, 180f)));
		}
	}

	// Update is called once per frame
	void Update () {

		
	}
}
