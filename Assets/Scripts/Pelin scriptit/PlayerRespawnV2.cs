using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawnV2 : MonoBehaviour
{
    public GameObject ball;
    public Transform respawnPosition;

    private void Start()
    {
        Instantiate(ball, respawnPosition.position, respawnPosition.rotation);
    }
    private void Update()
    {
        if (ball == null)
        {
            Instantiate(ball, respawnPosition.position, respawnPosition.rotation);
        }
    }
}
