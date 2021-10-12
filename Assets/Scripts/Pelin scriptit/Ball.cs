using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour {

	public Rigidbody2D rb;
	public Rigidbody2D hook;

	[SerializeField] float releaseTime = .50f;
	public float maxDragDistance = 2f;
	public float shootPower = 10;


	private PlayerRespawn Instance;

	public bool isPressed = false;

    private void Start()
    {
		//isPressed = true;
		rb.isKinematic = true;
		rb.velocity = Vector2.zero;
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
		//yield return new WaitForSeconds(releaseTime);


		//GetComponent<SpringJoint2D>().enabled = false;
		//this.enabled = false;

		yield return new WaitForSeconds(2f);

		PlayerRespawn.Instance.BallSpawn();

		Destroy(gameObject);
	}
}
