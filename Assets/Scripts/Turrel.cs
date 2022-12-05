using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Turrel : MonoBehaviour
{
    [SerializeField] private Transform m_PlayerPosition;
    [SerializeField] private float m_MinDistance = 3;
    [SerializeField] private float m_RotationSpeed;
    private void Start()
    {
        m_PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        if (Vector3.Distance(transform.position, m_PlayerPosition.position) < m_MinDistance)
        {
            FollowPlayer();
            ShootingPlayer();
            
        }
    }
    private void FollowPlayer()
    {
        Vector3 relative = m_PlayerPosition.position - transform.position;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, relative, m_RotationSpeed * Time.deltaTime, 0f);
        transform.rotation = Quaternion.LookRotation(newDir);
    }
    private void ShootingPlayer()
    {
        var bullet = GetComponent<BulletSpawn>();
        bullet.CreateBullet();
    }
}
