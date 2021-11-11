using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScoreScript : MonoBehaviour
{
    //korjaa highscore ei tunnista ensimmaista tuhottua

    public TextMeshProUGUI highScoreText;
    public int Score = 0;
    public string scoreString;
    public static HighScoreScript Instance;

    private void Start()
    {
        Instance = this;
        highScoreText.text = this.Score.ToString();
    }
    public void Scoretext()
    {
        highScoreText.text = this.Score.ToString();
        Score++;
    }
}
