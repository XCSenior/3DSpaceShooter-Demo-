using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicB_Control : MonoBehaviour {
	public AudioSource music;
	public Slider slider;
	// Use this for initialization
	void Start () {
		music.volume = slider.value;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void Volum()
    {
		music.volume = slider.value;
	}
}
