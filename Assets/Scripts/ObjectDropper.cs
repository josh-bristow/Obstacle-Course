using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rigidBody;
    void Start() 
    {
        rigidBody = GetComponent<Rigidbody>();
        meshRenderer = GetComponent<MeshRenderer>();

        rigidBody.useGravity = false;
        meshRenderer.enabled = false;
    }
    [SerializeField] float timeToWait = 4f;
    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            rigidBody.useGravity = true;
            meshRenderer.enabled = true;
        }
    }
}