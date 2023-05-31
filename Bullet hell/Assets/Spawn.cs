using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject objectPrefab;
    public GameObject playerObject;
    public float movementSpeed;
    public float spawnDelay = 1f;

    private float spawnTimer;

    private void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            SpawnObject();
            spawnTimer = spawnDelay;
        }
    }

    private void SpawnObject()
    {
        // Calculate a random position within the spawn area
        Vector3 spawnPosition = GetRandomSpawnPosition();

        // Instantiate the object at the spawn position
        GameObject spawnedObject = Instantiate(objectPrefab, spawnPosition, Quaternion.identity);

        // Calculate the direction from the spawned object to the player
        Vector3 directionToPlayer = (playerObject.transform.position - spawnedObject.transform.position).normalized;

        // Rotate the object towards the player
        spawnedObject.transform.rotation = Quaternion.LookRotation(Vector3.forward, directionToPlayer);

        // Apply movement to the object towards the player
        Rigidbody2D rb = spawnedObject.GetComponent<Rigidbody2D>();
        rb.velocity = directionToPlayer * movementSpeed;
    }

    private Vector3 GetRandomSpawnPosition()
    {
        // Define the boundaries of the spawn area
        float minX = transform.position.x - transform.localScale.x / 2f;
        float maxX = transform.position.x + transform.localScale.x / 2f;
        float minY = transform.position.y - transform.localScale.y / 2f;
        float maxY = transform.position.y + transform.localScale.y / 2f;

        // Generate random coordinates within the boundaries
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        return new Vector3(randomX, randomY, 0f);
    }
}