using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class FailClick : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip failSound;
    [SerializeField] GameObject pointClick;
    [SerializeField] ParticleSystem failParticles;
    Vector3 worldPosition;

    void Start()
    {

    }
 
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;
        if(Physics.Raycast(ray, out hitData, 1000))
            {
                worldPosition = hitData.point;
            }
    }

    public void OnMouseDown()
    {
        audioSource.PlayOneShot(failSound);
        pointClick.transform.position = worldPosition;
        failParticles.Play();
    }
}
