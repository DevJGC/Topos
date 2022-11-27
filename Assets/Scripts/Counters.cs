using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
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




    void Start()
    {

        record = PlayerPrefs.GetInt("record", 0);
        recordTextNumber.text = record.ToString();
        scoreTextNumber.text = score.ToString();
    }

    void Update()
    {

        timeLeftPartial -= Time.deltaTime;

        if (timeLeftPartial < 0)
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
            
             // revisar esto siguiente, cuando se acaba el tiempo
            if (contador == 0)
            {
                contador = 60;
            }
        }


        if (contador < 0)
        {
            Debug.Log("Time's up!");
        }
    }

    
}
