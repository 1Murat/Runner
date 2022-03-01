using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatformMove : MonoBehaviour
{
    
   public float rotatingSpeed = 10f;
 
    void Update()
    {
        transform.Rotate(Vector3.forward, rotatingSpeed * Time.deltaTime);
       
    }

    
}


