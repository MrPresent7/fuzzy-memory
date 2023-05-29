using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_spawn : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public GameObject obstacle;
    public Vector2 spawnPosition = new Vector2(0,0);
    public GameObject Mama;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("spawn", 3);
    }
    void spawn()
    {
        GameObject clone = Instantiate(obstacle, Mama.transform);
    }
}
