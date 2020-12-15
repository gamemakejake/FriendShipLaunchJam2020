using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CreatureFollow : MonoBehaviour
{
    public NavMeshAgent agent;

    Transform player;
    public bool canFollow = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canFollow)
        {
            FindPlayer();
            FollowPlayer();
        }
    }

    void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void FollowPlayer()
    {
        if (Vector3.Distance(transform.position, player.position) > agent.stoppingDistance)
        {
            agent.SetDestination(player.position);
        }
    }
}
