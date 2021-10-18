using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	public Rigidbody2D rb;
	public Rigidbody2D hook;

	//[SerializeField] float releaseTime = .50f;
	public float maxDragDistance = 2f;
	public float shootPower = 10;

	private bool isPressed = false;

	public GameObject Appelsiini;
	public GameObject Munakoiso;
	public GameObject Peach;
	public GameObject Paaryna;
	public GameObject Vesimelooni;
	//public GameObject deathEffect;

    private void Start()
    {
		rb.isKinematic = true;
		rb.velocity = Vector2.zero;

		StartCoroutine(RespawnAppelsiini());
    }

    void Update ()
	{
		if (isPressed)
		{
			Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

			if (Vector3.Distance(mousePos, hook.position) > maxDragDistance)
            {
				rb.position = hook.position + (mousePos - hook.position).normalized * maxDragDistance;
			}
			else
            {
				rb.position = mousePos;
			}
		}
	}

	void OnMouseDown ()
	{
		isPressed = true;
		rb.isKinematic = true;
	}

	void OnMouseUp ()
	{
		isPressed = false;
		rb.isKinematic = false;
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		rb.velocity = (mousePos - hook.position).normalized * -shootPower;

		StartCoroutine(Respawn());
	}

	IEnumerator Respawn ()
	{
		yield return new WaitForSeconds(2f);
		PlayerRespawn.Instance.BallSpawn();
		Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D enemyHit)
	{
		if (enemyHit.collider.CompareTag("Appelsiini"))
		{
			Destroy(gameObject);
			HighScoreScript.Instance.Scoretext();
		}
        if (enemyHit.collider.CompareTag("Munakoiso"))
        {
			Destroy(gameObject);
			HighScoreScript.Instance.Scoretext();
		}
        if (enemyHit.collider.CompareTag("Peach"))
        {
			Destroy(gameObject);
			HighScoreScript.Instance.Scoretext();
		}
        if (enemyHit.collider.CompareTag("Paaryna"))
        {

			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			//PlayerRespawn.Instance.PaarynaSpawn();
			Destroy(gameObject);
			HighScoreScript.Instance.Scoretext();
		}
        if (enemyHit.collider.CompareTag("Vesimelooni"))
        {
			//Instantiate(deathEffect, transform.position, Quaternion.identity);
			//PlayerRespawn.Instance.VesimelooniSpawn();
			Destroy(gameObject);
			HighScoreScript.Instance.Scoretext();
		}
	}

	IEnumerator RespawnAppelsiini()
	{
		yield return new WaitForSeconds(5);
		Destroy(gameObject);
	}
}
