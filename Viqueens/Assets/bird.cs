using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    public GameObject poopPrefab;
    public float speed;
    public float framesPerSecond = 2;
    public Sprite[] frames;

    private float timeLeft = 2.0f;
    private Rigidbody2D myRb2D;
    private SpriteRenderer spriteRenderer;
    private int currentFrameIndex = 0;
    private float frameTimer;

    // Start is called before the first frame update
    void Start()
    {
        myRb2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        frameTimer = 1;
        currentFrameIndex = 0;
    }

    // Update is called once per frame

    void Update()
    {
        frameTimer -= Time.deltaTime;
        if (frameTimer<0)
        {
            currentFrameIndex++;
            spriteRenderer.sprite = frames[currentFrameIndex%2];
            frameTimer = 1;
        }

        Vector2 velocity = myRb2D.velocity;
        velocity.x = -speed;
        myRb2D.velocity = velocity;

        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Instantiate(poopPrefab, transform.position, Quaternion.identity);
            timeLeft = Random.Range(2, 5);
        }
    }
}
