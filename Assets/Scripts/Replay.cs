using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{

    public GameObject panelGameOver;

    public void ReplayGame()
    {
       //panelGameOver.SetActive(false);
        SceneManager.LoadScene("Game");
        
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
