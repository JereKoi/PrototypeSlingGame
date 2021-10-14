using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyVesimelooni : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{

			//Spawner.instance.FruitsOnScreen--;
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			PlayerRespawn.Instance.VesimelooniSpawn();
			Respawn();
			Destroy(gameObject);
		}
	}
	IEnumerator Respawn()
	{
		yield return new WaitForSeconds(2f);
		//PlayerRespawn.Instance.VesimelooniSpawn();
		//Destroy(gameObject);
	}
}
