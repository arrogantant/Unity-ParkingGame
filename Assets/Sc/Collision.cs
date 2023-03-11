using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [SerializeField] AudioClip SFX_Crash;



    void Start() 
    {
         
    }
    void Update() 
    {

            
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("으악");
        GetComponent<AudioSource>().PlayOneShot(SFX_Crash);
    }

}

