using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyHolder : MonoBehaviour
{
    [SerializeField] private GameObject m_KeyType;
    
    private void OnTriggerEnter(Collider other)
    {
        Key key = other.GetComponent<Key>();
        
        if (key != null)
        {
            
            Destroy(key);
        }

        Door Door = other.GetComponent<Door>();

        if (Door != null)
        {
           
        }    
    }
}
