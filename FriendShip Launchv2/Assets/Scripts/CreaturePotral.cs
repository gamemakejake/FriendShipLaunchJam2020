using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaturePotral : MonoBehaviour
{
     public Creature creature;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PatrolWaypoints();
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Waypoint"))
        {
            creature.atWaypoint = true;
            Debug.Log("Hit");
        }
    }

    void PatrolWaypoints()
    {
        if (creature.atWaypoint)
        {
            creature.idx++;
            creature.atWaypoint = false;
        }
        else
        {
            creature.agent.SetDestination(creature.waypoints[creature.idx].transform.position);
        }
    }
}
