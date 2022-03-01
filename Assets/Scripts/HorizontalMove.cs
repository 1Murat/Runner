using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMove : MonoBehaviour
{
  
    public float speed ;
    public float distance;
    private float yStartPosition;
 
    
    void Start () {
        yStartPosition = transform.position.y;
    }
   
    
    void Update () {
 
        if (transform.position.y <= yStartPosition  + distance || transform.position.y >= yStartPosition )
        {
            speed *= -1;
        }
 
 
        transform.position = new Vector3(transform.position.x , transform.position.y + speed * Time.smoothDeltaTime , transform.position.z);
   
    } 
  
}
           
 
