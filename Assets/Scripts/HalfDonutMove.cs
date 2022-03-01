using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutMove : MonoBehaviour
{
    
   public float Distance;
   public float Speed;
   private float xStartPosition;
    
    void Start() {
        
        xStartPosition = transform.position.x;

    }


    void Update()
    {
        if(transform.position.x <= xStartPosition || transform.position.x >= xStartPosition + Distance){

            Speed *= -1;
        }

        transform.position = new Vector3(transform.position.x + Speed * Time.smoothDeltaTime, transform.position.y, transform.position.z);
        
        
    }

}
