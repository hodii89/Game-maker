using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Text scoreText;
    //public Text Highscore;

        int score = 0;

    private void Awake()
    {
      instance = this;
    }

    // Update is called once per frame
    void Start()
    {
        scoreText.text = score.ToString() + " COINS";
    }
    public void AddPoint() 
    {
        score += 1;
        scoreText.text = score.ToString() + " COINS";
    }
   
}

