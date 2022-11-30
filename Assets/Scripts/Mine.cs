using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mine : MonoBehaviour
{
    [SerializeField] private int m_Damage;

    void Start()
    {

    }
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var enemy = other.GetComponent<MyEnemy>();
            enemy.Hurt(m_Damage);
            Destroy(gameObject);
        }
    }
}
