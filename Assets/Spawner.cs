using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float delay = 75f; 
    public GameObject enemy;
    public bool canSpawnEnemy = true; 

    void Start()
    {
        InvokeRepeating("SpawnEnemy", delay, delay); 
    }

    // Update is called once per frame
    void SpawnEnemy() {
        if (canSpawnEnemy) { 
            Instantiate(enemy, new Vector3(Random.Range(-8, 8), transform.position.y, transform.position.z), Quaternion.identity);
        }
    }
    void Update()
    {
    }
}
