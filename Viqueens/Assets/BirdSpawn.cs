﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdSpawn : MonoBehaviour
{
	public GameObject birdPrefab;
	private float timer;
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
		Instantiate(birdPrefab, spawnPosition, Quaternion.identity);
	}

}
