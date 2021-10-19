using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public KeyCode up;
    public KeyCode down;

    public float jumpForce = 400;
    public Rigidbody reggiebody;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(up))
        {
            transform.TransformDirection(Vector3.forward * speed);
        }
        else if (Input.GetKey(down))
        {
            transform.TransformDirection(Vector3.back * speed);
        }

        if (Input.GetButtonDown("Jump"))
        {
            reggiebody.AddForce(Vector3.up * jumpForce);
            //Debug.Log("Jump up");
        }

        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        //        _transform.localPosition += _transform.right * h;
        //        _transform.localPosition += _transform.forward * v;

 //       Vector3 RIGHT = transform.TransformDirection(Vector3.right);
        Vector3 FORWARD = transform.TransformDirection(Vector3.forward);

 //       transform.localPosition += RIGHT * h;
        transform.localPosition += FORWARD * v;

    }
}