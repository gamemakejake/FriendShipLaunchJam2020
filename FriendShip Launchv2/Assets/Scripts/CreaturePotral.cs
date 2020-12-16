using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreaturePotral : MonoBehaviour
{
     public Creature creature;
    // Start is called before the first frame update
    void Start()
    {
        float dst = Vector3.Distance(creature.transform.position, creature.waypoints[creature.idx].transform.position);
        for (int i = 0; i < creature.waypoints.Length; i++)
        {
            float tmp = Vector3.Distance(creature.transform.position, creature.waypoints[i].transform.position);
            if (tmp < dst)
            {
                creature.idx = i;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        PatrolWaypoints();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == creature.waypoints[creature.idx])
        {
            creature.atWaypoint = true;
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
