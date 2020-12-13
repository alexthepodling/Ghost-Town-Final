using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GhostAgent : MonoBehaviour
{
    public GameObject characterDestination;
    private NavMeshAgent theAgent;

    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        theAgent.SetDestination(characterDestination.transform.position);
    }
}
