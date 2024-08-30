/*
Author: Hannah Bauer
Course: COP2671.0T1
Date: 8/30/2024
Assignment: Extra Credit - Challenge 1 Plane Programming
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    private float forwardInput;

    void Start()
    {

    }

    void FixedUpdate()
    {
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * Time.deltaTime); // Make the plane go forward

        if (forwardInput != 0) // Make the plane tilt only if the user presses the up/down arrows
        {
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * forwardInput); 
        }
    }
}