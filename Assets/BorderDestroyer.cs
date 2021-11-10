using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderDestroyer : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<ColliderVars>() != null)
        {
            Destroy(other.gameObject);
        }
    }
}
