using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{

    [SerializeField] AudioClip SFX_Crash;
    [SerializeField] GameObject gameOverPal;
    [SerializeField] GameObject HP3;
    [SerializeField] GameObject HP2;
    [SerializeField] GameObject HP1;
    [SerializeField] GameObject playerMove;
    public float maxHealth = 3;

    int health = 3;
    bool isDie = false;


    void Start() 
    {
        gameOverPal.SetActive(false);
    }
    void Update() 
    {
        HP();
        
         if (health == 0)
         {
            if(!isDie)
                gameOver();
                
            return;
         }   
    }

    void gameOver()
    {
        isDie = true;
        gameOverPal.SetActive(true);
        playerMove.GetComponent<Player>().enabled = false;
        
    }

    void HP()
    {
        if(health == 2)
        {
            HP3.SetActive(false);
        }
        if(health == 1)
        {
            HP2.SetActive(false);
        }
        if(health == 0)
        {
            HP1.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("으악");
        health--;
        GetComponent<AudioSource>().PlayOneShot(SFX_Crash);
    }

}

