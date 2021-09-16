using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public static Spawner Instance;

    public GameObject enemy;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    public GameObject SpawnPoint;
    public GameObject deathEffect;

    //public float health = 4f;

    public static int EnemiesAlive = 0;

    private int FruitsOnScreen = 10;

    public void Start()
    {
        Instance = this;
        Enemy enemy = gameObject.GetComponent<Enemy>();
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
            //maxFruitsOnScreen++;
            EnemiesAlive++;
            if (gameObject == null)
            {
                return;
            }
        }
        //else if (maxFruitsOnScreen < 10)
        //{
        //    return;
        //}
        else if (FruitsOnScreen >= 10)
        {
            Destroy(SpawnPoint);
            //pelin stoppi tahan
        }
    }

    //void Start()
    //{
    //    EnemiesAlive++;
    //}

    //void OnCollisionEnter2D(Collision2D enemyHit)
    //{
    //    if (enemyHit.collider.CompareTag("Player"))
    //    {
    //        Debug.Log("toimii");
    //        Destroy(enemy);
    //        Instantiate(deathEffect, transform.position, Quaternion.identity);
    //    }

    //Destroy(enemy);

    //if (colInfo.relativeVelocity.magnitude /*> health*/)
    //{
    //    Destroy(enemy);
    //    Instantiate(deathEffect, transform.position, Quaternion.identity);
    //}
    //}


}
