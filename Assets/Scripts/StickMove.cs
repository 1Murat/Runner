using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMove : MonoBehaviour
{   
   
    

    private float rotatespeed = 35.0f;

    void Update() {
        
        transform.localEulerAngles = new Vector3(0, Mathf.PingPong(Time.time * rotatespeed , 50) - 25 , 0 );
    }

    
 
}
