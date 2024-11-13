using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CharController : MonoBehaviour

{
    public float _speed = 7f;
    public float jumpForce = 1;
    private Rigidbody2D _rb;

    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        var _move = Input.GetAxis("Horizontal");
        transform.position = transform.position + new Vector3(_move * _speed * Time.deltaTime, 0, 0);

        if (!Mathf.Approximately(0, _move))
        {
            transform.rotation = _move > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.0001)
        {
            _rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
        }
    }

}