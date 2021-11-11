using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPaaryna : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D enemyHit)
	{
        if (Ball.instance.isReleased == true)
        {
			if (enemyHit.collider.CompareTag("Player"))
			{
				if (PlayerRespawn.Instance.whatToSpawnClone[5] == null)
				{
					Respawn();
				}
				Destroy(gameObject);
			}
		}

        if (enemyHit.collider.CompareTag("Deathbox"))
		{
			if (PlayerRespawn.Instance.whatToSpawnClone[5] == null)
			{
				Respawn();
			}
			Destroy(gameObject);
		}
	}
	IEnumerator Respawn()
	{
		yield return new WaitForSeconds(5);
		PlayerRespawn.Instance.PaarynaSpawn();
		yield return null;
	}
}
