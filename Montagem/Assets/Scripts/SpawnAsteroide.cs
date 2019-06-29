using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroide : MonoBehaviour
{
	public GameObject AsteroidePrefab;
	public float SpawnFrequency = 2f;
	public GameObject[] SpawnPoints;

	private float _timer;

	void Start()
	{
		_timer = SpawnFrequency;
	}

	void Update()
	{
		_timer -= Time.deltaTime;
		if (_timer <= 0)
		{
			Instantiate(AsteroidePrefab, SpawnPoints[RandomSpawn()].transform.position, Quaternion.identity);
			_timer = SpawnFrequency;
		}

	}

	private int RandomSpawn()
	{
		return Random.Range(0, SpawnPoints.Length);
	}

}
