using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickForce : MonoBehaviour
{
   
   public float forceapplied = 60;

   private void OnCollisionEnter(Collision other) {
       
       if(other.gameObject.CompareTag("player")){

           other.gameObject.GetComponent<Rigidbody>().AddForce(0,0,forceapplied);
       }
   }
}
