using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;    
using TMPro;
public class GameOver : MonoBehaviour
{
    // Referencia panel GameOver
    public GameObject panelGameOver;
    // Referencia panel GamePlay
    public GameObject panelGame;
    // Referencia puntos, record y texto final partida
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI recordText;
    public TextMeshProUGUI gameOverText;
    // Variable para guardar el record y puntos
    public int score;
    public int record;


    // Carga los puntos y el record
    // Los pasa a String para el Canvas
    // Si los puntos es mayor que el último record, se igualan y lo muestra en pantalla
    void Start()
    {
        record = PlayerPrefs.GetInt("record");
        score = PlayerPrefs.GetInt("score");
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
    }
    
    // No utilizado por ahora
    void Update()
    {
        
    }
}
