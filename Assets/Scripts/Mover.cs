using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game\nThis is an obstacle course");
        Debug.Log("Use the arrow keys or WASD to move");
    }

    void MovePlayer()
    {
        float xValue = (Input.GetAxis("Horizontal") * Time.deltaTime) * moveSpeed;
        float yValue = 0;
        float zValue = (Input.GetAxis("Vertical") * Time.deltaTime) * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}