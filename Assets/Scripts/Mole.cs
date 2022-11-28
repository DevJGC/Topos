using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mole : MonoBehaviour
{
    // Si se puede pulsar sobre el Topo
    bool isClicked;
    // Referencias partículas
    [SerializeField] ParticleSystem particleHit;
    [SerializeField] ParticleSystem particleMiss;
    // Referencia RigidBody del Topo
    [SerializeField] Rigidbody rb;
    // Referencia el Colisionador del Topo
    [SerializeField] SphereCollider sCollider;
    // Referencia sonidos Topo
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip hitSound;
    [SerializeField] AudioClip mazeSound;
    // Referencia al contador de aciertos desde el Script externo
    [SerializeField] Counters scriptContador;
    
    // Inicializa el contador
    void Start()
    {
        scriptContador = GameObject.FindObjectOfType<Counters>();
    }

    // No utilizado por ahora
    void Update()
    {
        
    }

    // Si se pulsa sobre el Topo y no se ha pulsado ya
    // Suma un punto
    // Reproduce sonido
    // Reproduce partículas
    // Desactiva el Topo (kinematic)
    // Lanza hacia arriba y lo rota
    // Desactiva su colisionador y lo borra después de 1 segundo para que de tiempo a mostrar las Anims
    public void OnMouseDown()
    {
        if (isClicked == false)
        {
            scriptContador.score = scriptContador.score + 1;
            audioSource.PlayOneShot(mazeSound);
            audioSource.PlayOneShot(hitSound);
            particleHit.Play();
            isClicked = true;
            rb.isKinematic = false;
            rb.AddForce(Vector3.up * 2000);
            rb.AddTorque(Vector3.up * 5000);
            Destroy(gameObject, 1f);
            sCollider.enabled = false;            
        }     
    }

    // Esta referencia se llama desde el Animator, para borrar el Topo
    public void EraseMole()
    {
        Destroy(gameObject);
    }
}
