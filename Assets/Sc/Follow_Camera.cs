using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_Camera : MonoBehaviour
{
    [SerializeField] GameObject followCamera;
    void Update()
    {
        transform.position = followCamera.transform.position + new Vector3(0,0,-10);
    }
}
