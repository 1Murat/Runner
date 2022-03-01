using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerControl : MonoBehaviour
{ 


    public float runningspeed;
    public float xSpeed;
    float mainspeed;
    float newx = 0;
    float touchXdelta = 0;
    float xlimitsol = -2.688f;
    float xlimitsag = -1.911f;
    //public GameObject panel;
    
    
    void Start() {

         mainspeed = runningspeed; 
        
    }

     void Update() {

         if(Input.touchCount > 0){

             Touch touch = Input.GetTouch(0);

             if(touch.phase == TouchPhase.Moved){
                
                touchXdelta = touch.deltaPosition.x / Screen.width;
             }

         }

       
         newx = transform.position.x + xSpeed * touchXdelta * Time.deltaTime;
         newx = Mathf.Clamp(newx, xlimitsol, xlimitsag);

        Vector3 newPosition = new Vector3(newx, transform.position.y, transform.position.z + mainspeed * Time.deltaTime);
        transform.position = newPosition;
        
    }

    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.CompareTag("Finish")){         
           
           SceneManager.LoadScene(7);          
        }       
      
    }

   
  
       
}
