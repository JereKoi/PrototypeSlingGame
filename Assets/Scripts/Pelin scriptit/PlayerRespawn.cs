using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;
    //public int random = new Random(5);

    int timeMillis;
    int timeRand;

    public static PlayerRespawn Instance;

    private void Start()
    {
        //timeRand = random.Next(5);
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
        //if (timeMillis >= timeRand)
        //{
        //    PlayerRespawn.Instance.AppelsiiniSpawn();
        //}

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


    //resettaa gameobjectin position ennemmin kuin tuhoa gameobject. Ota spawnlocation transformi ja kun transformi on tehty laita gameobject.setactive(true); kun ienumerator on mennyt lapi

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
