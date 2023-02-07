using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceblockSpawner : MonoBehaviour
{
    public GameObject iceblock;
    private float timer = 0;
    private float spawnTimer;
    private float timeMin = 5;
    private float timeMax = 9;
    private float distanceMin = 2;
    private float distanceMax = 5;
    public GameObject igloo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToIgloo = igloo.transform.position.x - transform.position.x;
        if (distanceToIgloo > 4)
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                SpawnNewReward();
                spawnTimer = Random.Range(timeMin, timeMax);
                timer = spawnTimer;
            }
        }
    }

    private void SpawnNewReward()
    {
        Vector3 spawnPosition = transform.position + Vector3.right * Random.Range(distanceMin, distanceMax);
        spawnPosition.z = 0;
        Instantiate(iceblock, spawnPosition, Quaternion.identity);
    }
}
