using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTopos : MonoBehaviour
{
    public Vector3[] positionHoles;


    public GameObject mole;

    public float timeToSpawn = 2f;
    public float timeToSpawnMax = 2f;
    public int countSpawn=0;


    void Start()
    {
  
    }

    
    void Update()
    {

        timeToSpawn -= Time.deltaTime;

        if (timeToSpawn <= 0)
        {
            SpawnMole();
            timeToSpawn = timeToSpawnMax;
            countSpawn ++;
        }

        if (countSpawn == 5)
        {
            timeToSpawnMax = 1.5f;
        }

        if (countSpawn == 10)
        {
            timeToSpawnMax = 1f;
        }

        if (countSpawn == 15)
        {
            timeToSpawnMax = 0.75f;
        }

        if (countSpawn == 20)
        {
            timeToSpawnMax = 0.65f;
        }
        
        if (countSpawn == 30)
        {
            timeToSpawnMax = 0.50f;
        }

        
    }

    public void SpawnMole()
    {
        int random = Random.Range(0, positionHoles.Length);
        Instantiate(mole, positionHoles[random], Quaternion.identity);
    }

}
