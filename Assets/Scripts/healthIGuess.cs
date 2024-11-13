using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class script : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitPoints = 5;
    public float speed = 3f;
    public Transform playerTransform;


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
          
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > playerTransform.position.x)
        {
            transform.localScale = new Vector3((float)0.34125, (float).4182656, 1);
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (transform.position.x < playerTransform.position.x)
        {
            transform.localScale = new Vector3((float)-0.34125, (float).4182656, 1);
            transform.position += Vector3.right * speed * Time.deltaTime;
        }

    }
}