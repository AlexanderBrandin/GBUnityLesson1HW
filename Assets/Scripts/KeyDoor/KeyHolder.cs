using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    private List<Key.KyeType> m_KeyList;
    private Key m_Key;
    private Door m_Door;

    public bool m_Triggered = false;

    private void Awake()
    {
        m_KeyList = new List<Key.KyeType>();
    }

    public void AddKey(Key.KyeType m_KeyType)
    {
        Debug.Log("Add Key: " + m_KeyType);
        m_KeyList.Add(m_KeyType);
    }

    public void RemoveKey(Key.KyeType m_KeyType)
    {
        m_KeyList.Remove(m_KeyType);
    }

    public bool ContainsKey(Key.KyeType m_KeyType)
    {
        return m_KeyList.Contains(m_KeyType);
    }

    private void OnTriggerEnter(Collider other)
    {
        m_Triggered = true;
        m_Key = other.GetComponent<Key>();
        m_Door = other.GetComponent<Door>();
    }

    private void OnTriggerExit(Collider other)
    {
        m_Triggered = false;
        m_Key = null;
        m_Door = null;
    }
    public void Use()
    {
        if (m_Key != null)
        {
            AddKey(m_Key.GetKyeType());
            Destroy(m_Key.gameObject);
        }

        if (m_Door != null)
        {
            m_Door.UseDoor();

            if (ContainsKey(m_Door.GetKyeType()))
            {
                RemoveKey(m_Door.GetKyeType());
                m_Door.UnlockDoor();
            }            
        }
    }
}
