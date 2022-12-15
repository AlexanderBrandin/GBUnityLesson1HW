using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private bool m_DoorLocked = true;
    [SerializeField] private bool m_DoorOpen = false;
    [SerializeField] private Key.KyeType m_KeyType;
    [SerializeField] private float m_OpenRotation;
    [SerializeField] private float m_CloseRotation;

    public Key.KyeType GetKyeType()
    { 
        return m_KeyType;
    }
    
    public void UnlockDoor()
    {
        Debug.Log("Unlock Door: " + m_KeyType);
        m_DoorLocked = false;
    }

    public void UseDoor()
    {
        if (!m_DoorLocked)
        {
            if (!m_DoorOpen)
            {
                Vector3 rotation = gameObject.transform.eulerAngles;
                rotation.y = m_OpenRotation;
                gameObject.transform.eulerAngles = rotation;
                m_DoorOpen = true;
            }

            else
            {
                Vector3 rotation = gameObject.transform.eulerAngles;
                rotation.y = m_CloseRotation;
                gameObject.transform.eulerAngles = rotation;
                m_DoorOpen = false;
            }
        }
    }
}

