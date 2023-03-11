using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finsh_Coll2 : MonoBehaviour
{
    public bool FiniShcolltwo = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == ("Player"))
        {
            FiniShcolltwo = true;
        }


    }
    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == ("Player"))
        {
            FiniShcolltwo = false;
        }
    }
}
