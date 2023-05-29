using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
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
        Instantiate(obstacle, Mama.transform.position, Quaternion.identity, Mama.transform);
    }
}
