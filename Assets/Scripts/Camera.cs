using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public float offsetX;

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (player.position.x > pos.x - offsetX)
        {
            pos.x = player.position.x + offsetX;
            transform.position = pos;
        }
    }
    
}
