using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGameScript : MonoBehaviour
{
    public void PlayGameButton()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
}
