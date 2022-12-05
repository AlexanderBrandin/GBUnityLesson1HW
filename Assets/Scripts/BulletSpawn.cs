using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawn : MonoBehaviour
{
    [SerializeField] private GameObject m_Bullet;
    [SerializeField] private Transform m_BulletSpawnPlace;

    public void CreateBullet()
    {
        var bullet = Instantiate(m_Bullet, m_BulletSpawnPlace.position, transform.rotation).GetComponent<Bullet>();
    }
}