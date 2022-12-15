using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] private KyeType m_KeyType;

    public enum KyeType
    {
        Brass,
        Old,
        Steel,
        Back
    }
    
    public KyeType GetKyeType()
    {
        return m_KeyType;
    }
        
}
