using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == false)
        {
            //grab original position
            Vector3 SusanPosition = transform.position;
            //Modidfy position
            SusanPosition.y = Mathf.Sin(Time.time) * 3;
            //Apply position
            transform.position = SusanPosition;
        }
    }
}
