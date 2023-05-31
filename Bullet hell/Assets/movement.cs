using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movementSpeed = 5f;
    

    private void Update()
    {
        // Get the mouse position in world space
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Set the z-coordinate to match the object's position

        // Calculate movement direction
        Vector3 movementDirection = (mousePosition - transform.position).normalized;

        // Apply movement to the object
        transform.position += movementDirection * movementSpeed * Time.deltaTime;
    }
}
