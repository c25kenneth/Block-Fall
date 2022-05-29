using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Endgame : MonoBehaviour
{
    // Start is called before the first frame update
    public Playermove playermovescript;
    public Renderer playerRenderer;
    public Spawner spawner;
    public GameObject cubeSpawner; 
    void Start()
    {
        spawner = cubeSpawner.GetComponent<Spawner>();
        playermovescript = GetComponent<Playermove>();
        playerRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator reloadScene() {
        yield return new WaitForSeconds(1); 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy") {
            playermovescript.canMove = false;
            playerRenderer.material.SetColor("_Color", Color.black);
            spawner.canSpawnEnemy = false;
            DestroyAll(); 
            StartCoroutine(reloadScene());
        }
    }

    void DestroyAll() {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i]);
        }
    }
}
