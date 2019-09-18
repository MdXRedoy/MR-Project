using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
   public float  Speed;

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 2 * Time.deltaTime * Speed, 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -2* Time.deltaTime * Speed, 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(2 * Time.deltaTime * Speed, -0, 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-2 * Time.deltaTime * Speed, 0, 1);
        }
    }
}
