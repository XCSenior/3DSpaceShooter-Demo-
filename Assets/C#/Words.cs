using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Words : MonoBehaviour {
	public Text text;
	
	public int n=0;
	// Use this for initialization
	void Start () {
		text.text = "0";
	}
	
	// Update is called once per frame
	void Update () {

        if (n >= 10)
        {
			SceneManager.LoadScene(4);
		}
		
	}
	public void AddSorce()
	{
		n += 1;
		text.text = n.ToString();
		Debug.Log(n.ToString());

	}
}
