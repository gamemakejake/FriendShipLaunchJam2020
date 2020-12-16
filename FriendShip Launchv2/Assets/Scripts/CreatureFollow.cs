using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CreatureFollow : MonoBehaviour
{
    public Creature creature;

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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            transform.LookAt(Camera.main.transform);
            canFollow = true;

        }
    }
    void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void FollowPlayer()
    {
        if (Vector3.Distance(transform.position, player.position) > creature.agent.stoppingDistance)
        {
            creature.agent.SetDestination(player.position);
        }
    }
}
