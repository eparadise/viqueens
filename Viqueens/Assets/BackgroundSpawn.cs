using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSpawn : MonoBehaviour
{
    public GameObject background;
    public float spawnTimer;

    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Spawn();
            timer = spawnTimer;
        }
    }

    void Spawn()
    {
        Vector3 position = new Vector3(transform.position.x + 3, transform.position.y, transform.position.z);
        Instantiate(background, position, Quaternion.identity);
    }
}
