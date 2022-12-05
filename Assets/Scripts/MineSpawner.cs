using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    [SerializeField] private GameObject m_Mine;
    [SerializeField] private Transform m_MineSpawnPlace;

    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(m_Mine, m_MineSpawnPlace.position, m_MineSpawnPlace.rotation);
        }
    }
}
