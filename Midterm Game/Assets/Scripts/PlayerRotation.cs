using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    public KeyCode right;
    public KeyCode left;

    public float RotateSpeed = 60f;

    // Update is called once per frame
    private void Update()
    {
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
