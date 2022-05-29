using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinspawner : MonoBehaviour
{
    public GameObject coin;
    public float coinDelay = 10f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCoin", coinDelay, coinDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCoin()
    {
        Instantiate(coin, new Vector3(Random.Range(-8, 8), transform.position.y, transform.position.z), Quaternion.identity);
    }
}
