using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Creature : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject[] waypoints;
    [HideInInspector]
    public bool atWaypoint = false;
    [HideInInspector]
    public int idx = 0;

    void Update()
    {
        if (idx >= waypoints.Length)
        {
            idx = 0;
        }
    }
}
