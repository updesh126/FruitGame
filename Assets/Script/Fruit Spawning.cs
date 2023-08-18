using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FruitSpawning : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform treeTransform; // Reference to the tree's Transform
    public float spawnInterval = 2.0f; // Adjust as needed
    private float timeSinceLastSpawn = 0.0f;
    
    private void Update()
    {
        // Check if it's time to spawn a new fruit
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnFruit();
            timeSinceLastSpawn = 0.0f; // Reset timer
        }
    }

    private void SpawnFruit()
    {
        // Calculate a random position within the tree's bounds
        Vector3 spawnPosition = CalculateSpawnPosition();

        // Instantiate the fruit prefab at the calculated position
        Instantiate(fruitPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector3 CalculateSpawnPosition()
    {
        // Calculate a random offset within the tree's local space
        Vector3 randomOffset = new Vector3(
            Random.Range(-0.5f, 0.5f),
            Random.Range(0.0f, 1.0f),
            Random.Range(-0.5f, 0.5f)
        );

        // Transform the random offset into world space using the tree's Transform
        Vector3 spawnPosition = treeTransform.TransformPoint(randomOffset);

        return spawnPosition;
    }
}
