using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflake : MonoBehaviour
{
    public AudioClip snowflake;
    void Start()
    {
        GetComponent<AudioSource>().clip = snowflake;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GetComponent<AudioSource>().Play();
        } 
    }
}
