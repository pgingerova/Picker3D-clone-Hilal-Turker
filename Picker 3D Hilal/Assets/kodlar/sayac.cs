using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sayac : MonoBehaviour
{
    [SerializeField]

    
    public int sayi;
    public int hedef;
    public int seviye;
    public bool basarili;
    public bool basarisiz;
    public GameObject oyuncu;
    public int top_top = 0;
    public GameObject tuzak;
    public Button buton;
    

    
    

    


  

    public void Start()
    {
        sayi = 0;
        hedef = 10;
        buton.interactable = false;
  
    }

    public void OnTriggerEnter(Collider other)
    {
        sayi++;

    }

    public void Basarili_mi()
    {

        gecit script = tuzak.GetComponent<gecit>();
        top_top = script.top_sayisi;

        if (sayi >= hedef )
            {
                basarili = true;
            }
            else if ( sayi!=0 && sayi < hedef && top_top>=sayi)
            {
                basarisiz = true;
            }
        
    }

    

    void Update()
    {
        Basarili_mi();
        if (basarili == true)
        {
            Destroy(tuzak);
            oyuncu_ayari script = oyuncu.GetComponent<oyuncu_ayari>();
            script.hiz = 3;
            hedef += 2;
            seviye += 1;
            
            basarili = false;
            
        }
        else if (basarisiz == true)

        {
            
            buton.interactable = true;
        }
           
        

    }
}
