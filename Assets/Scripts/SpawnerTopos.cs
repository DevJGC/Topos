using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTopos : MonoBehaviour
{
    public Vector3[] positionHoles;


    public GameObject mole;


    void Start()
    {
        Instantiate(mole, positionHoles[0], Quaternion.identity);
        Instantiate(mole, positionHoles[1], Quaternion.identity);
    }

    
    void Update()
    {
        
    }

}
