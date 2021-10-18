using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVesimelooni : MonoBehaviour
{
  //  private void Start()
  //  {
		//StartCoroutine(Respawn());
  //  }

    void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{
			//Respawn();
			//Spawner.instance.FruitsOnScreen--;
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			//PlayerRespawn.Instance.VesimelooniSpawn();
            if (PlayerRespawn.Instance.whatToSpawnClone[4] == null)
            {
				Respawn();
            }
			Destroy(gameObject);
		}
	}
	IEnumerator Respawn()
	{
		yield return new WaitForSeconds(15);
		PlayerRespawn.Instance.VesimelooniSpawn();
		yield return null;
	}
}
