using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BZ : MonoBehaviour {
	//public int s = 0;
	public AudioSource music;
	public AudioSource music2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision collision)
	{
		
		if (collision.collider.tag == "DJ")
			{
				//s += 1;
				music.Play();
				//Destroy(gameObject);
				//Debug.Log(s.ToString());
			gameObject.GetComponent<Renderer>().enabled = false;

		}
		//Destroy(gameObject);
		else
			music2.Play();
	}
}

