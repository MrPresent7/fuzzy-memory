using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public GameObject Mama;
    void Start()
    {
        Invoke("spawn", 3);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawn()
    {
        float a = Random.Range(-3f, 2f);
        
        Instantiate(obstacle, new Vector3(Mama.transform.position.x,a,0), Quaternion.identity, Mama.transform);
    }
}
