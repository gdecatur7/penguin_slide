using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowman : MonoBehaviour
{
    private double animTimer = 0.5;
    private double animCounterTimer = 0;
    private int index = 0;
    public Sprite[] snowManAnimation;
    public SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {
        animCounterTimer = 0;

    }

    // Update is called once per frame
    void Update()
    {

        animCounterTimer += Time.deltaTime;
        if (animCounterTimer >= index * animTimer)
        {
            if (index >= snowManAnimation.Length)
            {
                index %= snowManAnimation.Length;
            }
            // Debug.Log(animCounterTimer + "------" + index);
            sp.sprite = snowManAnimation[index];
            index++;
        }

    }
}
