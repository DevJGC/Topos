using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTopos : MonoBehaviour
{
    // Todas las posiciones posibles desde dónde saldrá el Topo
    public Vector3[] positionHoles;
    // Referencia al prefab del Topo
    public GameObject mole;
    // Tiempo para reaparecer
    public float timeToSpawn = 2f;
    // Tiempo máximo para reaparecer
    public float timeToSpawnMax = 2f;
    // Contador de reapariciones
    public int countSpawn=0;

    // Variable temporal para saber si se repite posición
    [SerializeField] int tempHole;

    // No utilizado por ahora
    void Start()
    {
  
    }

    // Resta un segundo en tiempo de ejecución
    // Si el tiempo parcial llega a 0, lanza el Spawner de Topos y suma una reaparición
    // Y conforme van apareciendo más, van acelerándose más el tiempo de reaparición, para que cada vez sea más rápido
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

    // Lanza el topo en una posición aleatoria de entro los datos que tiene del Array
    // Y si aparece en el mismo lugar lo mueve hacia delante o hacia detrás en su posición de reaparición
    public void SpawnMole()
    {
        
        int randomHole = Random.Range(0, positionHoles.Length);
        if (randomHole == tempHole)
        {
            if (randomHole == positionHoles.Length - 1)
            {
                randomHole--;
            }
            else
            {
                randomHole++;
            }
        }
        Instantiate(mole, positionHoles[randomHole], Quaternion.identity);
        tempHole = randomHole;
        //Debug.Log(tempHole);
    }
}
