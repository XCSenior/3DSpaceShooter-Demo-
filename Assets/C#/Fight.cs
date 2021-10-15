using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour {
    public AudioSource music;
    public float force;
    public float speed;
    private Vector3 spherePosition;
    public GameObject Object;
    public GameObject Plane;


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
       // Object.transform.position = Plane.transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
        {//按空格键
            spherePosition = Plane.transform.position;
            GameObject obj;
            //bool f = true;
            obj = Instantiate(Object, spherePosition, Quaternion.identity);
            obj.GetComponent<Transform>().transform.rotation = Plane.transform.rotation;
            obj.GetComponent<Rigidbody>().AddForce(Plane.transform.forward * force, ForceMode.Impulse);//给物体增加向前的爆发力
            music.Play();
            


        }


    }
}
