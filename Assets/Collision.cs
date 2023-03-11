using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool onecoll = false;
    bool twocoll = false;
    [SerializeField] GameObject Target;
    [SerializeField] AudioClip SFX_Finish;
    [SerializeField] AudioClip SFX_Crash;


    void Start() 
    {
         
    }
    void Update() 
    {
        if(onecoll == true && twocoll == true)
        {
            Debug.Log("주차성공");
            GetComponent<AudioSource>().PlayOneShot(SFX_Finish);
            Target.SetActive(false);
            onecoll = false;
            twocoll = false;
            

        }
            
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("으악");
        GetComponent<AudioSource>().PlayOneShot(SFX_Crash);
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

