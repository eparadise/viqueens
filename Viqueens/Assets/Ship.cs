using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    private Rigidbody2D myRb2D;
    public float speed;
    float damage = 100;
    public AudioClip[] clips = new AudioClip[2];
    private AudioSource myAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        myRb2D = GetComponent<Rigidbody2D>();
        myAudioSource = GetComponent<AudioSource>();
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

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            damage -= 10;
            AudioClip crash = clips[0];
            myAudioSource.PlayOneShot(crash);
            Destroy(collision.gameObject);
            
        }
        if (collision.gameObject.CompareTag("poop"))
        {
            damage -= 2;
            AudioClip poop = clips[1];
            myAudioSource.PlayOneShot(poop);
            Destroy(collision.gameObject);
        }
    }
}
