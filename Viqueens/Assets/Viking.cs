using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viking : MonoBehaviour
{

    public GameObject laser;
    public GameObject axe;
    public float rotationSpeed;
    public float laserLength;
    public int maxAngle;
    public int minAngle;


    private int multiplier = 1;
    private float ang = 0;
    private bool goingUp;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (multiplier == 1)
        {
            ang += rotationSpeed * Time.deltaTime; ;
        }
        else
        {
            ang -= rotationSpeed * Time.deltaTime; ;
        }
        if (ang >= maxAngle)
        {
            multiplier = -1;
        }
        if (ang <= minAngle)
        {
            multiplier = 1;
        }

        Quaternion quat = Quaternion.AngleAxis(ang, Vector3.forward);
        laser.transform.rotation = quat;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newAxe = Instantiate(axe, transform.position, Quaternion.identity);
            newAxe.GetComponent<Axe>().Throw(ang); 
        }
    }
}
