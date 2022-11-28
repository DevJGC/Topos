using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    int score;
    int record;

    void Start()
    {
        PlayerPrefs.SetInt("score", 0);
       // PlayerPrefs.SetInt("record", 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }   
        
    }
}
