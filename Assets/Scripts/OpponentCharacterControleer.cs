using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class OpponentCharacterControleer : MonoBehaviour
{
 
    [SerializeField] private Transform Target;
    private NavMeshAgent navMeshAgent;

    private void Awake() {
        
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void Update() {
        
        navMeshAgent.destination = Target.position;
    }

 
}
