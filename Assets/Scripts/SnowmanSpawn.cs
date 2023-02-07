using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowmanSpawn : MonoBehaviour
{
    public GameObject ObsSnowman;
    private float timer = 0;
    private float spawnTimer;
    private float timeMin = 3;
    private float timeMax = 7;
    private float distanceMin = 2;
    private float distanceMax = 5;
    
    void Start()
    {
    }

    void Update()
    {
        if (Camera.seeIgloo == false)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                //Debug.Log("HERE!");
                SpawnNewObstacle();
                spawnTimer = Random.Range(timeMin, timeMax);
                timer = spawnTimer;
            }
        } 
    }

    private void SpawnNewObstacle()
    {
        Vector3 spawnPosition = transform.position + Vector3.right * Random.Range(distanceMin, distanceMax);
        spawnPosition.z = 0;
        Instantiate(ObsSnowman, spawnPosition, Quaternion.identity);
    }
}
