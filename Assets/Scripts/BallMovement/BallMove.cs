using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D appelsiini;
    public Rigidbody2D munakoiso;
    public Rigidbody2D peach;
    public Rigidbody2D paaryna;
    public Rigidbody2D vesimelooni;
    public float speed = 400;
    // Start is called before the first frame update
    void Start()
    {
        appelsiini = GetComponent<Rigidbody2D>();
        appelsiini.AddForce(new Vector2(-20 * Time.deltaTime * speed, -20 * Time.deltaTime * speed));

        munakoiso = GetComponent<Rigidbody2D>();
        munakoiso.AddForce(new Vector2(-20 * Time.deltaTime * speed, -20 * Time.deltaTime * speed));

        peach = GetComponent<Rigidbody2D>();
        peach.AddForce(new Vector2(-20 * Time.deltaTime * speed, -20 * Time.deltaTime * speed));

        paaryna = GetComponent<Rigidbody2D>();
        paaryna.AddForce(new Vector2(-20 * Time.deltaTime * speed, -20 * Time.deltaTime * speed));

        vesimelooni = GetComponent<Rigidbody2D>();
        vesimelooni.AddForce(new Vector2(-20 * Time.deltaTime * speed, -20 * Time.deltaTime * speed));
    }
}
