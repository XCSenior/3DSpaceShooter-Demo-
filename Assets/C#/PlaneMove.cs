using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaneMove : MonoBehaviour {
    public Text text;
    private int sm=10;
    private float speed;
    public AudioSource music;
    // Use this for initialization
    void Start () {
        text.text = "10";
	}
	
	// Update is called once per frame
	void Update () {
        speed = 50f;
        if (Input.GetKey(KeyCode.Q))
        {
            speed = 150f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 moveDirection = transform.forward;
            transform.position += moveDirection * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 moveDirection = transform.forward;
            transform.position -= moveDirection * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 moveDirection = transform.right;
            transform.position -= moveDirection * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 moveDirection = transform.right;
            transform.position += moveDirection * Time.deltaTime * speed;
        }
        text.text = sm.ToString();
        if (sm < 0)
        {
            SceneManager.LoadScene(5);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "DaoD")
        {
             sm--;
        }

        music.Play();



    }
}
