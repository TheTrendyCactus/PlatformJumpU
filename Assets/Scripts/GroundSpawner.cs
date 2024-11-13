using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] objectToSpawn;
    private float timer;
    [SerializeField] public float timeBetweenSpawns;
    private int tilesSpawnedWithoutDanger;
    private bool isPlayerDead = false;

    public void StopSpawn()
    {
        isPlayerDead = true;
    }

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += StopSpawn;
    }

    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= StopSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        {
            timer += Time.deltaTime;

            if (timer > timeBetweenSpawns)
            {
                timer = 0;
                int randNum = Random.Range(1, 11);

                if ((randNum >= 5 && tilesSpawnedWithoutDanger >= 3) || tilesSpawnedWithoutDanger > 7)
                {
                    Instantiate(objectToSpawn[1], gameObject.transform.position, Quaternion.identity);
                    tilesSpawnedWithoutDanger = 0;
                }
                else
                {
                    Instantiate(objectToSpawn[0], gameObject.transform.position, Quaternion.identity);
                    tilesSpawnedWithoutDanger += 1;
                }
            }
        }
        
    }
}
