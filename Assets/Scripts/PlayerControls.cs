using Newtonsoft.Json.Converters;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float m_Speed = 3f;
    [SerializeField] private float m_RotationSpeed = 90f;
    [SerializeField] private Vector3 m_Direction;
    [SerializeField] private KeyHolder m_KeyHolder;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        m_KeyHolder = gameObject.GetComponent(typeof(KeyHolder)) as KeyHolder;
    }

    private void Update()
    {
        m_Direction.x = Input.GetAxis("Horizontal");
        m_Direction.z = Input.GetAxis("Vertical");

        var bullet = GetComponent<BulletSpawn>();

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        if (Input.GetButtonDown("E"))
        {
            Debug.Log("Use");

            if(m_KeyHolder.m_Triggered)
            {
                m_KeyHolder.Use();
            }
        }
    }

    private void FixedUpdate()
    {
        var speed = m_Direction * m_Speed * Time.deltaTime;
        transform.Translate(speed);
        transform.Rotate(Vector3.up * m_RotationSpeed * Input.GetAxis("Mouse X") * Time.deltaTime);
    }

    private void Shoot()
    {
        var bullet = GetComponent<BulletSpawn>();

        bullet.CreateBullet();
    }

    //    private void OnTriggerStay(Collider other)
    //    {
    //        Door Door = other.GetComponent<Door>();

    //        if (Input.GetButtonDown("Use"))
    //        {
    //            Door.UseDoor();
    //        }
    //    }
}
