using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed = 5f;
    public float detectionRange = 10f;
    private Rigidbody rb;
   [SerializeField] NavMeshAgent navMeshAgent;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
        //navMeshAgent.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Calculate the distance between the enemy and the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        // Check if the player is within the detection range
        if (distanceToPlayer <= detectionRange)
        {
            // Calculate the direction towards the player
            Vector3 direction = (player.transform.position - transform.position).normalized;

            // Move towards the player
            navMeshAgent.destination = player.transform.position;
            navMeshAgent.stoppingDistance = 7;
            //rb.velocity = direction * moveSpeed;
        }
        else
        {
            // Stop moving if the player is out of range
            rb.velocity = Vector3.zero;
        }
    }
}

