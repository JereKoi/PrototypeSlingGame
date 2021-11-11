using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	public Rigidbody2D rb;
	public Rigidbody2D hook;

	public float maxDragDistance = 2f;
	public float shootPower = 10;

	private bool isPressed = false;
	public bool isReleased = false;

	public static Ball instance;

	public GameObject Appelsiini;
	public GameObject Munakoiso;
	public GameObject Peach;
	public GameObject Paaryna;
	public GameObject Vesimelooni;
	//public GameObject deathEffect;

    private void Start()
    {
		instance = this;
		rb.isKinematic = true;
		rb.velocity = Vector2.zero;

		StartCoroutine(RespawnKivi());
    }

    void Update ()
	{
		if (isPressed)
		{
			
			Time.timeScale = 0.2f;
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
		isReleased = true;
		isPressed = false;
		rb.isKinematic = false;
		Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		rb.velocity = (mousePos - hook.position).normalized * -shootPower;
		Time.timeScale = 1f;
		StartCoroutine(Respawn());
	}

	IEnumerator Respawn ()
	{
		yield return new WaitForSeconds(2f);
		PlayerRespawn.Instance.BallSpawn();
		Destroy(gameObject);
	}

	public void OnCollisionEnter2D(Collision2D enemyHit)
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
			Destroy(gameObject);
			HighScoreScript.Instance.Scoretext();
		}
		if (enemyHit.collider.CompareTag("Vesimelooni"))
		{
			Destroy(gameObject);
			HighScoreScript.Instance.Scoretext();
		}
	}

	IEnumerator RespawnKivi()
	{
		yield return new WaitForSeconds(5);
		Destroy(gameObject);
	}
}
