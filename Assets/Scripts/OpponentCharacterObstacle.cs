using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpponentCharacterObstacle : MonoBehaviour
{
    
     private void OnCollisionEnter(Collision other) {

       
        if(other.gameObject.CompareTag("obstacle")){

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        
    }

    

}
