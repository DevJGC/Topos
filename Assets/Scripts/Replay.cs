using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    // Referencia el panel Game Over
    public GameObject panelGameOver;

    // Reinicia el nivel cuando se pulsa sobre el botón "Replay" (Conectado al Canvas GameOver)
    public void ReplayGame()
    {
        SceneManager.LoadScene("Game");     
    }

    // No utilizado por ahora
    void Start()
    {
        
    }

    // No utilizado por ahora
    void Update()
    {
        
    }
}
