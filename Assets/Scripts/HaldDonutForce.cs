using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HaldDonutForce : MonoBehaviour
{
   public float forceapplied = 80;

   private void OnCollisionEnter(Collision other) {
       
       if(other.gameObject.CompareTag("player")){

           other.gameObject.GetComponent<Rigidbody>().AddForce(forceapplied,0,0);
       }
   }
}
