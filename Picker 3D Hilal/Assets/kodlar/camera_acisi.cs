using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_acisi : MonoBehaviour
{
    [SerializeField]
    private GameObject Tasiyici;

    private void LateUpdate()
    {
        transform.position = new Vector3(Tasiyici.transform.position.x+44, transform.position.y, transform.position.z);
    }
}
