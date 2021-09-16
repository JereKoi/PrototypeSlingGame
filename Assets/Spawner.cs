using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance;

    public GameObject enemy;
    public GameObject SpawnPoint;
    public GameObject deathEffect;

    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    public static Spawner instance;
    public int FruitsOnScreen;

    public void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(-8.4f, 8.4f);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);

            FruitsOnScreen++;

            if (enemy == null)
            {
                Debug.Log("joo");
                FruitsOnScreen--;
                return;
            }
        }
        else if (FruitsOnScreen >= 10)
        {
            Destroy(SpawnPoint);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //uusi peli
        }
    }
}
