using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MyEnemy : MonoBehaviour
{
    [SerializeField] private int m_Health;
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;

    int m_CurrentWaypointIndex;

    void Start()
    {
        navMeshAgent.SetDestination(waypoints[0].position);
    }

    void Update()
    {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
        }
    }

    public void Hurt (int damage)
    {
        print("Ouch: " + damage);

        m_Health -= damage;

        if (m_Health <= 0)
        {
            Die();
        }
    }
    private void Die ()
    {
        Destroy (gameObject);
    }
}
