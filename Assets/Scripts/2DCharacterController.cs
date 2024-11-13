using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb2d;
    [SerializeField] private float speed = 6.0f;
    private Vector2 moveInputValue;
    private float xValue;
    [SerializeField] private float jumpForce = 60.0f;
    private bool isGrounded;

    public ProjectileBehavior ProjectilePrefab;
    public Transform LaunchOffset;

    private void OnEnable()
    {
        PlayerHealth.OnPlayerDeath += DisablePlayerMovement;
    }
    private void OnDisable()
    {
        PlayerHealth.OnPlayerDeath -= DisablePlayerMovement;
    }

    /*
    private void OnMove(InputValue value)
    {
        moveInputValue = value.Get<Vector2>();
        xValue = moveInputValue.x;
    }
    */

    /*
    private void OnFire()
    {
        Instantiate(ProjectilePrefab, LaunchOffset.position, transform.rotation);
    }
    */

    private void OnJump()
    {
        if (Mathf.Abs(rb2d.velocity.y) < 0.01)
        {
            rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }
    }

    private void Start()
    {
        EnablePlayerMovement();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        var _move = xValue;
        transform.position = transform.position + new Vector3(_move * speed * Time.deltaTime, 0, 0);

        if (!Mathf.Approximately(0, _move))
        {
            transform.rotation = _move > 0 ? Quaternion.Euler(0, 180, 0) : Quaternion.identity;
        }
        */
        
    }

    private void DisablePlayerMovement()
    {
        rb2d.bodyType = RigidbodyType2D.Static;
        speed = 0;
    }

    private void EnablePlayerMovement()
    {
        rb2d.bodyType = RigidbodyType2D.Dynamic;
        speed = 10.0f;
    }
}