using UnityEngine;
using System.Collections;
public class Test : MonoBehaviour
{
//随机产生的物体
private static GameObject sphere;
private static GameObject cube;
private static GameObject cylinder;
private static GameObject capsule;
public GameObject[] gameobject =
{
sphere,
cube,
cylinder,
capsule
};
//想要产生几波
public int waves;
//每波产生的数量
public int values;
//产生小行星之后延迟时间
private float spawnwait=0.5f;
// Use this for initialization
void Start ()
{
StartCoroutine(test01());
}
// Update is called once per frame
IEnumerator test01()
{
for (int j = 0; j < waves;j++ )
{
for (int i = 0; i < values;i++ )
{
Instantiate(gameobject[Random.Range(0,4)],transform.position,transform.rotation);
}
yield return new WaitForSeconds(spawnwait);
}
}
}