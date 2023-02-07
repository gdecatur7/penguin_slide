using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shatter : MonoBehaviour
{
    public Sprite[] frames;
    public float framesPerSecond = 5;
    public GameObject item;
    SpriteRenderer spriteRenderer;
    int currentFrameIndex = 0;
    float frameTimer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        frameTimer = (1f / framesPerSecond);
        currentFrameIndex = 0;
    }

    // cycle through the sprites of explosion animation
    void FixedUpdate()
    {
        frameTimer -= Time.deltaTime;

        if (frameTimer <= 0)
        {
            currentFrameIndex++;
            if (currentFrameIndex >= frames.Length)
            {
                var spawnPos = transform.position;
                //if (SceneManager.GetActiveScene().name == "Level2")
                //{
                //    spawnPos.x += 6;
                //}
                //else {
                    spawnPos.x += 3;
                //}
                Destroy(gameObject);
                Instantiate(item, spawnPos, Quaternion.identity);
                return;
            }
            frameTimer = (1f / framesPerSecond);
            spriteRenderer.sprite = frames[currentFrameIndex];
        } 
    }
}
