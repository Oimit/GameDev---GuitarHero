using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderVars : MonoBehaviour
{
    public bool IsPassed;
    public float speedForce;
    void Start()
    {
        speedForce = 2f;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speedForce, Space.World);
    }
}
