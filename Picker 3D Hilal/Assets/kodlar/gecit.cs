using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gecit : MonoBehaviour
{
    public int top_sayisi;
    public void start()
    {
        top_sayisi = 0;
    }
    public void OnTriggerEnter(Collider other)
    {
        top_sayisi++;

    }

   


   
}
