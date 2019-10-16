using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    public GameObject prefab;
    private GameObject[,] cubes;
    private GameObject[,] positionoffsets;
    public AudioSource[] sound;
    public AudioSource sound1;
    public AudioSource sound2;

    private void Start()
    {
        sound = GetComponents<AudioSource>();
        sound1 = sound[0];
        sound2 = sound[1];
        cubes = new GameObject[5, 5];
        positionoffsets = new GameObject[6, 6];
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(prefab, new Vector3(2 * i - 5, 2 * j - 5, 0), Quaternion.identity);
            }
        }
    }
    void Update()
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sound1.Play();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            sound2.Play();
        }

        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)

                {
                    cubes[i, j].transform.position =
                                 new Vector3(cubes[i, j].transform.position.x, Mathf.Sin(Time.time) + positionoffsets[i, j].transform.position.y, 0);

                    //Cube.y = Mathf.Sin(Time.time) * 3;

                    //transform.position = Cube;
                }
            }
        }
    }
}

    
