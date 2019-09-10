using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float offsetX;
    private AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (player.position.x > (pos.x - offsetX))
        {
            pos.x = player.position.x + offsetX;
            transform.position = pos;
        }
    }
}
