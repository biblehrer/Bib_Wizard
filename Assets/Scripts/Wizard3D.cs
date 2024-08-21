using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard3D : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 movement = Vector3.zero;

        if (Input.GetKey("w"))
        {
            movement += Vector3.up;
        }

        transform.position += movement.normalized * Time.deltaTime ;  

        if (Input.GetMouseButtonUp(0) )
        {

        }


    }
}
