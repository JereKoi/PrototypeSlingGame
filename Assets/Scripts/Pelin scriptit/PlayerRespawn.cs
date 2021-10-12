using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    public static PlayerRespawn Instance;

    private void Start()
    {
        Instance = this;
        BallSpawn();
    }
    private void Update()
    {
        if (whatToSpawnClone == null)
        {
            Debug.Log("menee tänne");
            BallSpawn();
        }
    }

    public void BallSpawn()
    {
        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
}
