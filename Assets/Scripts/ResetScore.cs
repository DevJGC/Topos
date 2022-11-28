using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{   
    // Variables Score y Record
    int score;
    int record;

    // Al comenzar pone a 0 el Score, y si hace falta, para borrar el Record se "descomenta" la escritura del PlayerPrefs "record"
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
       // PlayerPrefs.SetInt("record", 0);
    }

    // Sale del Juego y del Editor
    // Esto está puesto en la cámara, para que se tenga acceso desde cualquier lugar del juego
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }   
        
    }
}
