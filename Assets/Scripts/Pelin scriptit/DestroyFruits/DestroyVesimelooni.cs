using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVesimelooni : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{

            if (PlayerRespawn.Instance.whatToSpawnClone[4] == null)
            {
				Respawn();
            }
			Destroy(gameObject);
		}

		if (enemyHit.collider.CompareTag("Deathbox"))
		{
			if (PlayerRespawn.Instance.whatToSpawnClone[4] == null)
			{
				Respawn();
			}
			Destroy(gameObject);
		}
	}
	IEnumerator Respawn()
	{
		yield return new WaitForSeconds(5);
		PlayerRespawn.Instance.VesimelooniSpawn();
		yield return null;
	}
}
