using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public KeyCode right;
    public KeyCode left;

    public float RotateSpeed = 60f;

    public float speed = 6f;
    public float gravity = -9.18f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        if (Input.GetKey("left shift") && isGrounded)
        {
            speed = 12f;
        }
        else
        {
            speed = 6f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKey(left))
        {
            transform.Rotate(-Vector3.up * RotateSpeed * Time.deltaTime);
        }

        else if (Input.GetKey(right))
        {
            transform.Rotate(Vector3.up * RotateSpeed * Time.deltaTime);
        }
    }
}