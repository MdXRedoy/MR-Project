using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuilder : MonoBehaviour
{
    public GameObject Cube;

    void Start()
    {

        BuildAWallAtZ(-2);
        BuildAWallAtZ(2);
        BuildAWallAtX(-2);
        BuildAWallAtX(-2);
        BuildAWallAtY(2);
        BuildAWallAtY(-2);



        void BuildAWallAtZ(float z)
        {
            for (int xPos = 0; xPos < 10; xPos++)
            {
                for (int yPos = 0; yPos < 15; yPos++)
                {
                    Instantiate(Cube, new Vector3(xPos * 2 - 10, yPos * 1.5f, z), Quaternion.identity);
                }
            }
        }
    }
    void BuildAWallAtX(float x)
    {
        for (int zPos = 0; zPos < 15; zPos++)
        {
            for (int yPos = 0; yPos < 10; yPos++)
            {
                Instantiate(Cube, new Vector3(x, yPos * 2, zPos), Quaternion.identity);

            }
        }
    }

    void BuildAWallAtY(float y)
    {
        for (int xPos = 0; xPos < 20; xPos++)
        {
            for (int zPos = 0; zPos < 10; zPos++)
            {
                Instantiate(Cube, new Vector3(xPos - 10, y, zPos), Quaternion.identity);
            }
        }
    }
}



//void Start()
   // {
       // Instantiate(Cube, new Vector3(0, 5, 9), Quaternion.identity);

     //   for (int i = 0; i < 10; i++)
       // {
       //     Instantiate(Cube, new Vector3(i * 2 - 10, 0, 0), Quaternion.identity);
       // }

       // for (int xPos = 0; xPos < 10; xPos++)
       // {
            //for (int yPos = 0; yPos < 5; yPos++)
            //{
                //Instantiate(Cube, new Vector3(xPos * 2 - 10, yPos * 1.5f, 0), Quaternion.identity);
           // }
     //   }
   // }
//}

