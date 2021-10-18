using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMunakoiso : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{
			//Respawn();
			//Spawner.instance.FruitsOnScreen--;
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			//PlayerRespawn.Instance.VesimelooniSpawn();
			if (PlayerRespawn.Instance.whatToSpawnClone[2] == null)
			{
				Respawn();
			}
			Destroy(gameObject);
		}
	}

	IEnumerator Respawn()
	{
		yield return new WaitForSeconds(15);
		PlayerRespawn.Instance.MunakoisoSpawn();
		yield return null;
	}
}