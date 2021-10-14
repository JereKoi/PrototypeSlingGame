using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject deathEffect;
	public GameObject enemy;

	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{
			Destroy(enemy);
			//Spawner.instance.FruitsOnScreen--;
			Instantiate(deathEffect, transform.position, Quaternion.identity);

		}
	}
}
