using UnityEngine;

public class ProjectileBehavior : MonoBehaviour
{
    private float speed = 20f;

    // Update is called once per frame
    void Update()
    {
            transform.position += -transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<enemyBehavior>();
        if (enemy)
        {
            enemy.TakeHit(1);
        }

        Destroy(gameObject);
    }
}
