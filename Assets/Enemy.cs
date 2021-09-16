using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public GameObject deathEffect;
	public GameObject enemy;
	public static int EnemiesAlive = 0;
	public int FruitsOnScreen = 10;
	public Spawner SpawnerScript;
	
	
	
	void Start ()
	{
		Spawner spawner = gameObject.GetComponent<Spawner>();
		EnemiesAlive++;
	}

	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Player"))
		{
			Destroy(enemy);
			FruitsOnScreen--;
			Instantiate(deathEffect, transform.position, Quaternion.identity);
		}
	}
}
