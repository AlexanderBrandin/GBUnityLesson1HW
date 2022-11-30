using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
   [SerializeField] private float m_Speed = 3f;
   [SerializeField] private Vector3 m_Direction;

    void Start()
    {
        
    }

    private void Update()
    {
        m_Direction.x = Input.GetAxis("Vertical");
        m_Direction.z = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        var speed = m_Direction * m_Speed * Time.deltaTime;
        transform.Translate(speed);
    }
}
