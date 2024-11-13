using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] private float minimumSpawnTime;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float maximumSpawnTime;
    public Transform playerTransform;

    private float numSpawns = 0;
    private float timeUntilSpawn;

    private void Awake()
    {
        SetTimeUntilSpawn();
    }

    private void Update()
    {
        timeUntilSpawn -= Time.deltaTime;

        if (timeUntilSpawn <= 0)
        {
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
            numSpawns++;
        }
        if(numSpawns % 20 == 0)
        {
            minimumSpawnTime = maximumSpawnTime - Convert.ToSingle(0.1);
        }
    }

    private void SetTimeUntilSpawn()
    {
        timeUntilSpawn = UnityEngine.Random.Range(minimumSpawnTime, maximumSpawnTime);
    }


}
