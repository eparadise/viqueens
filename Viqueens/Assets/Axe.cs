using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public float speed;
    public GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.Find("ship1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Throw(float angle)
    {
        Rigidbody2D myRB = GetComponent<Rigidbody2D>();
        float radians = angle * Mathf.Deg2Rad;
        Vector3 target = new Vector3(Mathf.Cos(radians) * 2, Mathf.Sin(radians) * 2, 0);
        myRB.velocity = target * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "hammer")
        {
            ship.GetComponent<Ship>().health += 10;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "mop")
        {
            ship.GetComponent<Ship>().health += 5;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "obstacle")
        {
            Destroy(collision.gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Destroy(collision.gameObject);
        }
    }

}
