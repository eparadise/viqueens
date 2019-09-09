using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    private Rigidbody2D myRb2D;
    public GameObject poopPrefab;
    public float speed;
    float timeLeft = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        myRb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
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
