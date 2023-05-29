using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 3f;

    private void Update()
    {
        MoveBird();
    }

    private void MoveBird()
    {
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
    }
}
