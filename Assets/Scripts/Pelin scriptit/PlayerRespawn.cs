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
        AppelsiiniSpawn();
        MunakoisoSpawn();
        PeachSpawn();
        VesimelooniSpawn();
        PaarynaSpawn();
    }
    private void Update()
    {
        if (whatToSpawnClone[0] == null)
        {
            BallSpawn();
        }
        if (whatToSpawnClone[1] == null)
        {
            AppelsiiniSpawn();
        }
        if (whatToSpawnClone[2] == null)
        {
            MunakoisoSpawn();
        }
        if (whatToSpawnClone[3] == null)
        {
            PeachSpawn();
        }
        if (whatToSpawnClone[4] == null)
        {
            VesimelooniSpawn();
        }
        if (whatToSpawnClone[5] == null)
        {
            PaarynaSpawn();
        }
    }

    public void BallSpawn()
    {
        whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }

    public void AppelsiiniSpawn()
    {
        whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    public void MunakoisoSpawn()
    {
        whatToSpawnClone[2] = Instantiate(whatToSpawnPrefab[2], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    public void PeachSpawn()
    {
        whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[3], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    public void VesimelooniSpawn()
    {
        whatToSpawnClone[4] = Instantiate(whatToSpawnPrefab[4], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
    public void PaarynaSpawn()
    {
        whatToSpawnClone[5] = Instantiate(whatToSpawnPrefab[5], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }
}
