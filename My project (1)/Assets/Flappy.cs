using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    public float flapForce = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FlapBird();
        }
    }

    private void FlapBird()
    {
        rb.velocity = Vector2.up * flapForce;
    }
}