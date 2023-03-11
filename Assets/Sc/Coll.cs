using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour
{
    
    [SerializeField] GameObject Target;
    [SerializeField] GameObject Target2;

    [SerializeField] AudioClip SFX_Finish;
    [SerializeField] AudioClip SFX_Crash;
    [SerializeField] ParticleSystem Particle;
    [SerializeField] SpriteRenderer Spgr;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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

            
        }
        
    }
}
