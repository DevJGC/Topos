using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Counters : MonoBehaviour
{
    public float timeLeftPartial = 1f;
    public float contador = 60.0f;
    public GameObject mole; 
    public TextMeshProUGUI text;
    public TextMeshProUGUI scoreTextNumber;
    public TextMeshProUGUI recordTextNumber;
    public int score = 0;
    public int record = 0;
    public GameObject panelGameOver;
    public GameObject panelGame;

    void Start()
    {
        mole.SetActive(true);
        record = PlayerPrefs.GetInt("record", 0);
        score = PlayerPrefs.GetInt("score", 0);
        recordTextNumber.text = record.ToString();
        scoreTextNumber.text = score.ToString();
        PlayerPrefs.SetInt("score", 0);
    }

    void Update()
    {
        timeLeftPartial -= Time.deltaTime;
        if (timeLeftPartial < 0 && contador >0)
        {
            timeLeftPartial = 1f;
            contador -= 1;
            text.text = contador.ToString();
            scoreTextNumber.text = score.ToString();
            if (score >= record)
            {
                record = score;
                PlayerPrefs.SetInt("record", record);
                recordTextNumber.text = record.ToString();
            }
        }

        if (contador == 0)
        {
            panelGameOver.SetActive(true);
            panelGame.SetActive(false);
            mole.SetActive(false);
            PlayerPrefs.SetInt("score", score);
        }
    }
}

