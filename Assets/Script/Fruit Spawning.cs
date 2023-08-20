using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FruitSpawning : MonoBehaviour
{
    public GameObject fruitPrefab;
    public Transform treeTransform; 
    public float spawnInterval = 2.0f; 
    private float timeSinceLastSpawn = 0.0f;
    
    private void Update()
    {
        
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= spawnInterval)
        {
            SpawnFruit();
            timeSinceLastSpawn = 0.0f; 
        }
    }

    private void SpawnFruit()
    {
        
        Vector3 spawnPosition = CalculateSpawnPosition();

        
        Instantiate(fruitPrefab, spawnPosition, Quaternion.identity);
    }

    private Vector3 CalculateSpawnPosition()
    {
        
        Vector3 randomOffset = new Vector3(
            Random.Range(-0.5f, 0.5f),
            Random.Range(0.0f, 1.0f),
            Random.Range(-0.5f, 0.5f)
        );

        
        Vector3 spawnPosition = treeTransform.TransformPoint(randomOffset);

        return spawnPosition;
    }
}