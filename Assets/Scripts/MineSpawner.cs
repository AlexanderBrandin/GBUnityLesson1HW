using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSpawner : MonoBehaviour
{
    [SerializeField] private GameObject m_Mine;
    [SerializeField] private Transform m_MineSpawnPlace;

    void Update()
    {
        if (Input.GetButtonDown("F"))
        {
            CreateMine();
        }
    }
    private void CreateMine()
    {
        var mine = Instantiate(m_Mine, m_MineSpawnPlace.position, transform.rotation).GetComponent<Mine>();
    }
}
