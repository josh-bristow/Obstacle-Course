using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        spinCube();
    }

    void spinCube()
    {
        float xRotate = 0;
        float yRotate = 1f;
        float zRotate = 0;
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
