using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTopos : MonoBehaviour
{
    public Vector3[] positionHoles;


    public GameObject mole;


    void Start()
    {
       for (int i=0; i<positionHoles.Length; i++)
       {
            Instantiate(mole, positionHoles[i], Quaternion.identity);
       }
        
  
    }

    
    void Update()
    {
        
    }

}
