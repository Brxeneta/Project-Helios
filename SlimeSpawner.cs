using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeSpawner : MonoBehaviour
{

    public Transform[] spawnPoints;

    public GameObject Slime;

    public float DownTime = 0.5f; //Time between spawns

    private float SpawnTimer = 0.0f; //Time to start spawning when entering room

    //private bool SlimeSpawned = false;

    void Update()
    {
        if (Time.time >= SpawnTimer)
        {

                SpawnSlime();
                SpawnTimer = Time.time + DownTime;
                //SlimeSpawned = true;
            

        }
    }

    public void SpawnSlime()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
                Instantiate(Slime, spawnPoints[i].position, Quaternion.identity);
            
        }
    }
}
