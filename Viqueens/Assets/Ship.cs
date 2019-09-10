using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ship : MonoBehaviour
{
    private Rigidbody2D myRb2D;
    public float speed;
    public float health = 100;
    public AudioClip[] clips = new AudioClip[2];
    private AudioSource myAudioSource;
    public Slider HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        myRb2D = GetComponent<Rigidbody2D>();
        myAudioSource = GetComponent<AudioSource>();
        HealthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = myRb2D.velocity;
        vel.x = speed;
        myRb2D.velocity = vel;
        if (health <= 0)
        {
            myRb2D.gravityScale = 5;
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
 
    }

    void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("obstacle"))
        {
            health -= 10;
            AudioClip crash = clips[0];
            myAudioSource.PlayOneShot(crash);
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.CompareTag("poop"))
        {
            health -= 2;
            AudioClip poop = clips[1];
            myAudioSource.PlayOneShot(poop);
            Destroy(collision.gameObject);
        }

        HealthBar.value = health;
    }
}
