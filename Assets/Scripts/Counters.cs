using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Counters : MonoBehaviour
{
    // Contador de tiempo parcial
    public float timeLeftPartial = 1f;
    // Contador de tiempo total
    public float contador = 60.0f;
    // Prefab Topo
    public GameObject mole; 
    // Texto de tiempo
    public TextMeshProUGUI text;
    // Texto de puntaje
    public TextMeshProUGUI scoreTextNumber;
    // Texto de record
    public TextMeshProUGUI recordTextNumber;
    // Puntos
    public int score = 0;
    // Record
    public int record = 0;
    // Panel GameOver
    public GameObject panelGameOver;
    // Panel Game
    public GameObject panelGame;

    // Activa Topo
    // Carga record del PlayerPrefs
    // Carga puntaje del PlayerPrefs
    // Pasa el Record al Canvas
    // Pasa el Puntaje al Canvas
    // Pone el Score a 0
    void Start()
    {
        mole.SetActive(true);
        record = PlayerPrefs.GetInt("record", 0);
        score = PlayerPrefs.GetInt("score", 0);
        recordTextNumber.text = record.ToString();
        scoreTextNumber.text = score.ToString();
        PlayerPrefs.SetInt("score", 0);
    }

    // Actualiza el contador de tiempo parcial
    // Actualiza el contador de tiempo total
    // Actualiza el texto de tiempo
    // Si el contador de tiempo Total llega a 0
    // Desactiva el Topo y lanza grupo GameOver
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

