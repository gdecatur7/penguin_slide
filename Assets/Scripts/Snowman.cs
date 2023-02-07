using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    private double animationChangeTimer = 0.5;
    private float animCounterTimer;
    private int index = 0;
    public Sprite[] snowManAnimation;
    public SpriteRenderer sp;
    private float offSetX = 10;
    public Transform player;
    public AudioClip death;

    // Start is called before the first frame update
    void Start()
    {
        animCounterTimer = 0;
        death = GetComponent<AudioSource>().clip;
    }

    // Update is called once per frame
    void Update()
    {
       
        animCounterTimer += Time.deltaTime;
        if (animCounterTimer >= index * animationChangeTimer)
        {
            sp.sprite = snowManAnimation[index % snowManAnimation.Length];
            index++;
        }
       


        //if (gameObject.transform.position.x < player.position.x - offSetX)
        //{
        //    Destroy(gameObject);
        //}
    }
}