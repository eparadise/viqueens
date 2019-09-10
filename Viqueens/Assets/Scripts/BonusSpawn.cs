using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawn : MonoBehaviour
{
    public GameObject hammerPrefab;
    public GameObject mopPrefab;
    private float timer = 5;
    public float spawnTimer;
    public float distanceMin;
    public float distanceMax;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            SpawnNewObstacle();
            timer = spawnTimer;
        }
    }

    void SpawnNewObstacle()
    {
        Vector3 spawnPosition = transform.position + Vector3.up * Random.Range(distanceMin, distanceMax);
        spawnPosition.z = 0;
        int spawnMop = Random.Range(0, 2);
        if (spawnMop == 0)
        {
            Instantiate(mopPrefab, spawnPosition, Quaternion.identity);
        }
        else {
            Instantiate(hammerPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
