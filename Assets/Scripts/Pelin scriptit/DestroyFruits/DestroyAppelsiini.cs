using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAppelsiini : MonoBehaviour
{
	int timeMillis;
	int timeRand;

	//  private void Update()
	//  {
	//if (timeMillis >= timeRand)
	//      {
	//	PlayerRespawn.Instance.AppelsiiniSpawn();
	//}
	//  }

	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{
			//Respawn();
			//Spawner.instance.FruitsOnScreen--;
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			//PlayerRespawn.Instance.VesimelooniSpawn();
			if (PlayerRespawn.Instance.whatToSpawnClone[1] == null)
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