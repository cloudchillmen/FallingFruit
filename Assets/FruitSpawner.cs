using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    public GameObject fruitPrefab;
    void Start()
    {
        InvokeRepeating("SpawnFruit", 0f, 1f);
    }

    void SpawnFruit()
    {
        float randomX = Random.Range(-9.5f, 9.5f);
        Vector3 spawnPosition = new Vector3(randomX, 
            transform.position.y, 
            transform.position.z);
        GameObject fruit = Instantiate(fruitPrefab,
            spawnPosition, 
            transform.rotation);
        Destroy(fruit, 5f);
    }
}
