using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject panelGameOver;
    public GameObject panelGame;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI recordText;
    public TextMeshProUGUI gameOverText;

     public int score;
     public int record;


    void Start()
    {
        record = PlayerPrefs.GetInt("record");
        score = PlayerPrefs.GetInt("score");
        PlayerPrefs.SetInt("score", score);
        recordText.text = record.ToString();
        scoreText.text = score.ToString();

        if (score >= record)
        {
            gameOverText.text = "NEW RECORD!";
        }
        else
        {
            gameOverText.text = "GAME OVER";
        }

        Debug.Log("Score: " + score);
    }

    
    void Update()
    {
        
    }
}
