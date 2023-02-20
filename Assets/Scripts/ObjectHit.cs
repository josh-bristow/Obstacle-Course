using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Invoke("ResetObjectColor", 2);
        GetComponent<MeshRenderer>().material.color = Color.white;
    }

    void ResetObjectColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.yellow;
    }
}
