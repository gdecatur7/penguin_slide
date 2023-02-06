using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PenguinController : MonoBehaviour
{
    private float walkingSpeed = 2;
    public GameObject shatterPrefab;
    private float jumpingSpeed = 3;
    public Sprite jumpSprite;
    public Sprite walkSprite;
    public SpriteRenderer sr;
    Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = new Vector3();
        movement.x = walkingSpeed;
        movement.y = rb2D.velocity.y;


        if (Input.GetKey(KeyCode.Space))
        {
            movement.y = jumpingSpeed;
            sr.sprite = jumpSprite;
        }
        else
        {
            sr.sprite = walkSprite;
        // note for Katherine: you can add the walking animation here I just did normally walking for now
        }

        rb2D.velocity = new Vector2(movement.x, movement.y);
        transform.right = rb2D.velocity.normalized;

        // raycast looking for igloo
        Vector2 origin = transform.position;
        Vector2 target = new Vector2(transform.position.x + 2, transform.position.y);
        Vector2 direction = target - origin;
        RaycastHit2D hit = Physics2D.Raycast(origin, direction, direction.magnitude);
        if (hit.collider != null && hit.collider.CompareTag("Finish"))
        {
            // sliding animation
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("block"))
        {
            Instantiate(shatterPrefab, col.gameObject.transform.position, Quaternion.identity);
            Destroy(col.gameObject);

        }

        if (col.gameObject.CompareTag("item"))
        {
            Destroy(col.gameObject);
        }

        if (col.gameObject.CompareTag("enemy"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
