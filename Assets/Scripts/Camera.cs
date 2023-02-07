using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float offsetX;
    private AudioSource backgroundMusic;
    public static Boolean seeIgloo = false;
    public GameObject Igloo;
    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        backgroundMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello");
        if (seeIgloo == false)
        {
            Vector3 pos = transform.position;

            if (player.position.x > pos.x - offsetX)
            {
                pos.x = player.position.x + offsetX;
                transform.position = pos;
            }

            //// raycast looking for igloo
            //Vector2 origin = player.position;
            //Vector2 target = new Vector2(transform.position.x + 5, transform.position.y);
            //Vector2 direction = target - origin;
            //RaycastHit2D hit = Physics2D.Raycast(origin, direction, direction.magnitude);

            //if (hit.collider != null && hit.collider.CompareTag("Finish"))
            //{

            //    seeIgloo = true;
            //}

            //check for distsance (4) between igloo and camera. 10x12.
            float distance = Igloo.transform.position.x - transform.position.x;
            //Debug.Log(distance);
            if (distance < 4.5)
            {
                seeIgloo = true;
                //Debug.Log("SEE");
            }
        }

    }
    
}
