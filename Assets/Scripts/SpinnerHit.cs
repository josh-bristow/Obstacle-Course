using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) 
    {
        Invoke("ResetWallColor", 2);
        GetComponent<MeshRenderer>().material.color = Color.white;
    }

    void ResetWallColor()
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
