using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiniSh_Coll : MonoBehaviour
{
    public bool FiniShcollone = false;

    void OnTriggerEnter2D(Collider2D other) 
    {
        
        if(other.tag == ("Player"))
        {
            FiniShcollone = true;
        }

    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag == ("Player"))
        {
            FiniShcollone = false;
        }
    }
}
