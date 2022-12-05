using Newtonsoft.Json.Converters;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] private float m_Speed = 3f;
    [SerializeField] private float m_RotationSpeed = 90f;
    [SerializeField] private Vector3 m_Direction;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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

    private void OnTriggerEnter(Collider other)
    {
        Door Door = other.GetComponent<Door>();

        if (Input.GetButtonDown("Use"))
        {
            Door.UseDoor();
        }
    }
}
