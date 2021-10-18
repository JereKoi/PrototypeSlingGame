using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPaaryna : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{
			//Respawn();
			//Spawner.instance.FruitsOnScreen--;
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			//PlayerRespawn.Instance.VesimelooniSpawn();
			if (PlayerRespawn.Instance.whatToSpawnClone[5] == null)
			{
				Respawn();
			}
			Destroy(gameObject);
		}
	}
	IEnumerator Respawn()
	{
		yield return new WaitForSeconds(15);
		PlayerRespawn.Instance.PaarynaSpawn();
		yield return null;
	}
}
