using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool onecoll = false;
    bool twocoll = false;
    [SerializeField] GameObject Target;

    void Start() 
    {
         
    }
    void Update() 
    {
        if(onecoll == true && twocoll == true)
        {
            Debug.Log("주차성공");
            Target.SetActive(false);
            onecoll = false;
            twocoll = false;
            
        }
            
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("으악");
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == ("Trigger1"))
        {
            onecoll = true;
        }

        if(other.tag == ("Trigger2"))
        {
            twocoll = true;
        }
    }
}

