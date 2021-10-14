using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public KeyCode right;
    public KeyCode left;
    public KeyCode up;
    public KeyCode down;

    public float jumpForce = 10;
    public Rigidbody reggiebody;

    // Update is called once per frame
    void Update()
    {
        float xMovement = 0;
        float zMovement = 0;

        if (Input.GetKey(right))
        {
            xMovement += speed * Time.deltaTime;
        }
        else if (Input.GetKey(left))
        {
            xMovement -= speed * Time.deltaTime;
        }

        if (Input.GetKey(up))
        {
            zMovement += speed * Time.deltaTime;
        }
        else if (Input.GetKey(down))
        {
            zMovement -= speed * Time.deltaTime;
        }

        xMovement = this.gameObject.transform.position.x + xMovement;
        zMovement = this.gameObject.transform.position.z + zMovement;

        this.gameObject.transform.position = new Vector3(xMovement, this.gameObject.transform.position.y, zMovement);

        if (Input.GetButtonDown("Jump"))
        {
            reggiebody.AddForce(Vector3.up * jumpForce);
            //Debug.Log("Jump up");
        }
    }
}