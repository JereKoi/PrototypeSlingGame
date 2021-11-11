using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameScript : MonoBehaviour
{
    public void PlayGameButton()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
}
