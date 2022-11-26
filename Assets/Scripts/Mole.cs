using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    bool isClicked;
    
    [SerializeField] ParticleSystem particleHit;
    [SerializeField] ParticleSystem particleMiss;
    [SerializeField] Rigidbody rb;
    [SerializeField] SphereCollider sCollider;
    [SerializeField] AudioSource audioSource;

    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip mazeSound;
    
    void Start()
    {
      
    }

    
    void Update()
    {
        
    }


    public void OnMouseDown()
    {
        if (isClicked == false)
        {
            audioSource.PlayOneShot(mazeSound);
            audioSource.PlayOneShot(hitSound);
            particleHit.Play();
            isClicked = true;
           // Debug.Log("Clicked");   
            rb.isKinematic = false;
            rb.AddForce(Vector3.up * 2000);
            rb.AddTorque(Vector3.up * 5000);
            Destroy(gameObject, 2f);
            sCollider.enabled = false;            
        }
        
    }

    public void EraseMole()
    {
        Destroy(gameObject);
    }

}
