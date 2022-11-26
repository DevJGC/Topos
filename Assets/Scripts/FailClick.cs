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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        //Debug.Log("Fail");
        audioSource.PlayOneShot(failSound);
    }
}
