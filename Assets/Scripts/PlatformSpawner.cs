using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject[] objectToSpawn;
    private float timer;
    private int platformChain;
    [SerializeField] public float timeBetweenSpawns;
    private int tilesSpawnedWithoutDanger;



    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer > timeBetweenSpawns)
        {
            timer = 0;
            int randNum = Random.Range(0, 100);

            if (randNum <= 20 || tilesSpawnedWithoutDanger > 30 || (randNum >= 60 && (platformChain <= 6 && platformChain > 0)))
            {
                Instantiate(objectToSpawn[1], gameObject.transform.position, Quaternion.identity);
                tilesSpawnedWithoutDanger = 0;
                platformChain += 1;
            }
            else if (randNum % 10 == 0)
            {
                Instantiate(objectToSpawn[0], gameObject.transform.position, Quaternion.identity);
                tilesSpawnedWithoutDanger = 0;
                platformChain += 1;
            }
            else
            {
                tilesSpawnedWithoutDanger += 1;
                platformChain = 0;
            }
        }
    }
}
