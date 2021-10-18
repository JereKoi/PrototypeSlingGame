using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int Health = 5;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Munakoiso")
        {
            Health--;
            Debug.Log("Health:" + Health);
            Death();
        }
        else if (collision.gameObject.tag == "Paaryna")
        {
            Health--;
            Debug.Log("Health:" + Health);
            Death();
        }
        else if (collision.gameObject.tag == "Peach")
        {
            Health--;
            Debug.Log("Health:" + Health);
            Death();
        }
        else if (collision.gameObject.tag == "Vesimelooni")
        {
            Health--;
            Debug.Log("Health:" + Health);
            Death();
        }
        else if (collision.gameObject.tag == "Appelsiini")
        {
            Health--;
            Debug.Log("Health:" + Health);
            Death();
        }
    }

    public void Death()
    {
        if (Health <= 0)
        {
            Debug.Log("Hävisit pelin :)");
            SceneManager.LoadScene(0);  //<---- Gameover screen
        }
    }
}
