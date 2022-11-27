using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
using System;
using TMPro;


public class Timer : MonoBehaviour
{
    public float timeLeftPartial = 1f;
    public float contador = 60.0f;
    public GameObject mole;
    
    public TextMeshProUGUI text;



    void Start()
    {
        
    }

    void Update()
    {

        timeLeftPartial -= Time.deltaTime;

        if (timeLeftPartial < 0)
        {
            timeLeftPartial = 1f;
            contador -= 1;
            text.text = contador.ToString();
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
