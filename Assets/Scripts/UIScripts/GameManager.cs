using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    public Text HighscoreText;
    //public Text Highscore;

    int score = 0;
    int Highscore = 0;

    private void Awake()
    {
      instance = this;
    }

    // Update is called once per frame
    void Start()
    {
        Highscore = PlayerPrefs.GetInt("Highscore", 0);
        scoreText.text = score.ToString() + " CREDITS";
        HighscoreText.text = "Highscore " + Highscore.ToString();
    }
    public void AddPoint() 
    {
        score += 1;
        scoreText.text = score.ToString() + " CREDITS";
        if( Highscore < score)
        {
            PlayerPrefs.SetInt("Highscore", score);
        }

    }
   
}

