using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float m_Speed = 4;
    [SerializeField] private int m_Damage;

    void Update()
    {
        transform.Translate(Vector3.forward * m_Speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<MyEnemy>().Hurt(m_Damage);
        }
        
        Destroy(gameObject);
    }
}
