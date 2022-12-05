using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyEnemy : MonoBehaviour
{
    [SerializeField] private int m_Health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
