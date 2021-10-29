using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAppelsiini : MonoBehaviour
{
	int timeMillis;
	int timeRand;

	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{
			if (PlayerRespawn.Instance.whatToSpawnClone[1] == null)
			{
				Respawn();
			}
			Destroy(gameObject);
		}

        if (enemyHit.collider.CompareTag("Deathbox"))
        {
            if (PlayerRespawn.Instance.whatToSpawnClone[1] == null)
            {
				Respawn();
            }
			Destroy(gameObject);
        }
	}
	IEnumerator Respawn()
	{
		yield return new WaitForSeconds(5);
		PlayerRespawn.Instance.MunakoisoSpawn();
		yield return null;
	}
}