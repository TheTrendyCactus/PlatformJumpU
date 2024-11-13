using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] public float environmentSpeed;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 4)
        {
            Destroy(gameObject);
        }
        else
        {
            rb2d.velocity = Vector2.left * environmentSpeed * Time.fixedDeltaTime;
        }
        
    }
}
