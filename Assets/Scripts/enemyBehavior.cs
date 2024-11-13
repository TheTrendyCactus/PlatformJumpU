using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class enemyBehavior : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitPoints = 5;
    public float speed = 6f;
    public Transform[] patrolPoints;
    public int patrolDestination;


    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitPoints;
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (patrolDestination == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[0].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[0].position) < .2f)
            {
                patrolDestination = 1;
            }
        }
        if (patrolDestination == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[1].position, speed * Time.deltaTime);
            if (Vector2.Distance(transform.position, patrolPoints[1].position) < .2f)
            {
                patrolDestination = 0;
            }


        }
    }
}
