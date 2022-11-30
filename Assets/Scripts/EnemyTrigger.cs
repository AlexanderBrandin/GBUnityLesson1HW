using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    [SerializeField] private GameObject m_Zombi;
    [SerializeField] private Transform m_EnemySpawner;

    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(m_Zombi, m_EnemySpawner.position, m_EnemySpawner.rotation);
            Destroy(gameObject);
        }
    }
}