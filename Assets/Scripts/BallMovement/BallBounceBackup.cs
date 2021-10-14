using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceBackup : MonoBehaviour
{
    public Rigidbody2D appelsiini;
    public Rigidbody2D munakoiso;
    public Rigidbody2D peach;
    public Rigidbody2D paaryna;
    public Rigidbody2D vesimelooni;
    Vector3 LastVelocity;
    // Start is called before the first frame update
    void Start()
    {
        appelsiini = GetComponent<Rigidbody2D>();
        munakoiso = GetComponent<Rigidbody2D>();
        peach = GetComponent<Rigidbody2D>();
        paaryna = GetComponent<Rigidbody2D>();
        vesimelooni = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        LastVelocity = appelsiini.velocity;
        LastVelocity = munakoiso.velocity;
        LastVelocity = peach.velocity;
        LastVelocity = paaryna.velocity;
        LastVelocity = vesimelooni.velocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = LastVelocity.magnitude;
        var direction = Vector3.Reflect(LastVelocity.normalized, collision.contacts[0].normal);
        appelsiini.velocity = direction * Mathf.Max(speed, 0f);
        munakoiso.velocity = direction * Mathf.Max(speed, 0f);
        peach.velocity = direction * Mathf.Max(speed, 0f);
        paaryna.velocity = direction * Mathf.Max(speed, 0f);
        vesimelooni.velocity = direction * Mathf.Max(speed, 0f);
    }
}
