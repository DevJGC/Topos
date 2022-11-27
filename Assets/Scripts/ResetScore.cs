using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    int score;
    int record;

    void Start()
    {
        //score = PlayerPrefs.GetInt("score", 0);
        //record = PlayerPrefs.GetInt("record", 0);
        PlayerPrefs.SetInt("score", 0);
        //PlayerPrefs.SetInt("record", 0);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
