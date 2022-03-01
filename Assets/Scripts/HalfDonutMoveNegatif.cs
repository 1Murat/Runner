using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfDonutMoveNegatif: MonoBehaviour
{
    public float HalfDonutDistance;
    public float HalfDonutSpeed;
    private float xStartposition;
    
    void Start()
    {
        xStartposition = transform.position.x;
        
    }

    void Update()
    {
        if(transform.position.x <= xStartposition + HalfDonutDistance || transform.position.x >= xStartposition){

            HalfDonutSpeed *=-1;
        }

        transform.position = new Vector3(transform.position.x + HalfDonutSpeed* Time.smoothDeltaTime, transform.position.y, transform.position.z);

    }
}
