using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyuncu_ayari : MonoBehaviour
{
    
    [SerializeField]
    public float hiz = 1f;
    public Rigidbody rg;
    public float oyunPoz_Z;
    public float tasi_Z;
    
    

    private void Awake()
    {
        rg = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        oyunPoz_Z = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
    }

    private void OnMouseDrag()
    {
        var mousePoint = Input.mousePosition;
        mousePoint.z = oyunPoz_Z;
        tasi_Z = Camera.main.ScreenToWorldPoint(mousePoint).z;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tuzak")
        {
            hiz = 0;

        }
        else if (other.tag == "tuzak1")
        {
            hiz = 0;

        }
        else if (other.tag == "tuzak2")
        {
            hiz = 0;

        }
        else if (other.tag == "final")
        {

            
            SceneManager.LoadScene("continue1");

        }
        else
            hiz = 3;
    }
   

    void FixedUpdate()
    {
        var x = (hiz * Time.fixedDeltaTime) * -1;
        var newPos = transform.position + new Vector3(x, 0, 0);
      
             if (tasi_Z > 2.22f)
                 {
                     newPos.z = 2.22f;
                 }
             else if (tasi_Z < -2.22f)
                 {
                     newPos.z = -2.22f;
                 }
             else
                     newPos.z = tasi_Z;

                rg.MovePosition(newPos);

               
        
    }

}
