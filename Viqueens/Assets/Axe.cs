using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
