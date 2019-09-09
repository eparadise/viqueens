using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    private Rigidbody2D myRb2D;
    private SpriteRenderer sr;
    public float speed;
    float damage = 100;
    // Start is called before the first frame update
    void Start()
    {
        myRb2D = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = myRb2D.velocity;
        vel.x = speed;
        myRb2D.velocity = vel;

        if (damage <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            damage -= 10;
            
        }
        if (collision.gameObject.CompareTag("Poop"))
        {
            damage -= 2;
        }
    }
}
