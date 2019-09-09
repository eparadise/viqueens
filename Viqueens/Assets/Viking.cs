using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Viking : MonoBehaviour
{

    public GameObject laser;
    public float rotationSpeed;
    public float laserLength;
    public int maxAngle;

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
        float angle = rotationSpeed * Time.deltaTime;
        if (multiplier == 1)
        {
            ang += angle;
        }
        else
        {
            ang -= angle;
        }
        if (ang >= maxAngle)
        {
            multiplier = -1;
        }
        if (ang <= 0)
        {
            multiplier = 1;
        }

        Quaternion quat = Quaternion.AngleAxis(multiplier * angle, Vector3.forward);
        laser.transform.rotation *= quat;
    }
}
