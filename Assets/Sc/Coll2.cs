using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Coll2 : MonoBehaviour
{
    
    [SerializeField] GameObject Target;
    [SerializeField] GameObject Target2;

    [SerializeField] AudioClip SFX_Finish;
    [SerializeField] AudioClip SFX_Crash;
    [SerializeField] ParticleSystem Particle;
    [SerializeField] SpriteRenderer Spgr;
    [SerializeField] GameObject ClearPal;
    [SerializeField] GameObject playerMove;

    void Start()
    {
        GetComponent<Player>();
        GetComponent<FiniSh_Coll>();
        GetComponent<Finsh_Coll2>();
        ClearPal.SetActive(false);
    }

    void Update()
    {
        if(GameObject.Find("Trigger1").GetComponent<FiniSh_Coll>().FiniShcollone == true && GameObject.Find("Trigger2").GetComponent<Finsh_Coll2>().FiniShcolltwo == true)
            {
                Debug.Log("주차성공");
                Spgr.color = Color.green;
                Particle.Play();
                GetComponent<AudioSource>().PlayOneShot(SFX_Finish);
                Target.SetActive(false);
                Target2.SetActive(false);
                Destroy(Particle,2);
                ClearPal.SetActive(true);
                playerMove.GetComponent<Player>().enabled = false;
            }     
    }
}
