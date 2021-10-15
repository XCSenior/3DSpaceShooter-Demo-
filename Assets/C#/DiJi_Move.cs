using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiJi_Move : MonoBehaviour {
	//public Text text;
	//public int s = 0;
	private Words words;
	private float speed = 10f;
	// Use this for initialization
	void Start () {
		words = GameObject.Find("Canvas").GetComponent<Words>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 moveDirection = this.transform.forward;
		//transform.position += moveDirection * Time.deltaTime * 10f;
        if (transform.position.x>1000f|| transform.position.x < -1000f||
			transform.position.y > 1000f || transform.position.y < -1000f||
			transform.position.z > 1000f || transform.position.z < -1000f)
        {
			speed = -10f;
		}
        
		transform.position += moveDirection * Time.deltaTime * speed;
		//text.text = s.ToString();
		//Debug.Log(s.ToString());
	}
	void OnCollisionEnter(Collision collision)
    {
		if (collision.collider.tag == "DaoD") 
		{
			words.AddSorce();
			Destroy(gameObject);
		
			//Debug.Log(s.ToString());
		}
		
		
	}
	
}
