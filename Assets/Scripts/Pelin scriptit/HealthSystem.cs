using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HealthSystem : MonoBehaviour
{
    public int Health = 5;

    [SerializeField] TextMeshProUGUI HealthText;

    public GameObject GameoverScreen;
    public GameObject PauseScreen;
    public GameObject PauseButtoni;
    public GameObject Heart;
    public GameObject HealthTextUI;
    public GameObject ScoreBackground;
    public GameObject ScoreText;

    private void Start()
    {
        HealthText.text = this.Health.ToString();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Munakoiso")
        {
            Health--;
            HealthText.text = this.Health.ToString();
            Death();
        }
        else if (collision.gameObject.tag == "Paaryna")
        {
            Health--;
            HealthText.text = this.Health.ToString();
            Death();
        }
        else if (collision.gameObject.tag == "Peach")
        {
            Health--;
            HealthText.text = this.Health.ToString();
            Death();
        }
        else if (collision.gameObject.tag == "Vesimelooni")
        {
            Health--;
            HealthText.text = this.Health.ToString();
            Death();
        }
        else if (collision.gameObject.tag == "Appelsiini")
        {
            Health--;
            HealthText.text = this.Health.ToString();
            Death();
        }
    }

    public void Death()
    {
        if (Health <= 0)
        {
            Time.timeScale = 0f;
            AdsManager.instance.PlayInterstitialAd();
            HealthTextUI.SetActive(false);
            Heart.SetActive(false);
            GameoverScreen.SetActive(true);
            ScoreBackground.SetActive(false);
            ScoreText.SetActive(false);
            //SceneManager.LoadScene(0);  //<---- Gameover screen
        }
    }

    public void ContinueButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }

    public void HighScoreButton()
    {
        //Gameobject highscorelist.setactive(true);
    }

    public void PauseButton()
    {
        Time.timeScale = 0f;
        PauseScreen.SetActive(true);
        PauseButtoni.SetActive(false);
    }

    public void PauseContinueButton()
    {
        PauseScreen.SetActive(false);
        PauseButtoni.SetActive(true);
        Time.timeScale = 1f;
    }

    public void PlayGameButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
        HealthTextUI.SetActive(true);
        Heart.SetActive(true);
        ScoreBackground.SetActive(true);
        ScoreText.SetActive(true);
    }
}
