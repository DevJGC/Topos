using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FailClick : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip failSound;


    void Start()
    {

    }

 
    void Update()
    {
        
    
    }

    public void OnMouseDown()
    {
        

        audioSource.PlayOneShot(failSound);
    }
}
