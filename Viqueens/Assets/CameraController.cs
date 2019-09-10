using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float offsetX;
    private AudioSource myAudioSource;
    public GameObject[] backgrounds;
    private float distanceMoved;
    private float backgroundWidth;
    private int backgroundNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        backgroundWidth = (backgrounds[0].transform.localScale.x * 250.0f) / 100.0f;

        for (int i=0; i<backgrounds.Length; i++)
        {
            backgrounds[i].transform.position = new Vector3(i*backgroundWidth, backgrounds[i].transform.position.y, backgrounds[i].transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x  += 1 * Time.deltaTime;
        distanceMoved += 1 * Time.deltaTime;
        if (distanceMoved >= backgroundWidth)
        {
            Vector3 backgroundPos = backgrounds[backgroundNumber - 1].transform.position;
            backgroundPos.x += 3 * backgroundWidth;
            backgrounds[backgroundNumber - 1].transform.position = backgroundPos;
            if (backgroundNumber == 3)
            {
                backgroundNumber = 1;
            }
            else {
                backgroundNumber++;
            }
            distanceMoved = 0;
        }
        transform.position = pos;
    }
}
