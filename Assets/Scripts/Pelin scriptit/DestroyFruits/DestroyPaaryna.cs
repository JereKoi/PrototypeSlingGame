using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPaaryna : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{

			//Spawner.instance.FruitsOnScreen--;
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			PlayerRespawn.Instance.PaarynaSpawn();
			Respawn();
			Destroy(gameObject);
		}
	}
	IEnumerator Respawn()
	{
		yield return new WaitForSeconds(2f);
		//PlayerRespawn.Instance.PaarynaSpawn();
		//Destroy(gameObject);
	}
}
