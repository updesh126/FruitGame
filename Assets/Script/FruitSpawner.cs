using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    public float spawnInterval = 5f;

    private void Start()
    {
        StartCoroutine(SpawnFruits());
    }

    private IEnumerator SpawnFruits()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);

            Vector3 spawnPosition = transform.position;
            Quaternion spawnRotation = Quaternion.identity;
            GameObject spawnedFruit = Instantiate(fruitPrefab, spawnPosition, spawnRotation);

           // Rigidbody fruitRigidbody = spawnedFruit.GetComponent<Rigidbody>();
           // fruitRigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}
