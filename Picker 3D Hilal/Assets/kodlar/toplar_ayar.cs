using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplar_ayar : MonoBehaviour
{
    private Rigidbody rg;
    private void Awake()
    {
        rg = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if(transform.position.y > 0.1f)
        {
            rg.MovePosition( new Vector3(transform.position.x, 0.1f, transform.position.z));
        }
    }
}
