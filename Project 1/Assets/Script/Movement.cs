using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Vector3 auto;
    void Start()
    {
        auto = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time) * 2, transform.position.z) + auto;

        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += Vector3.up;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += Vector3.down;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += Vector3.left;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.position += Vector3.right;
            }
        }
    }
}
