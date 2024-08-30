/*
Author: Hannah Bauer
Course: COP2671.0T1
Date: 8/30/2024
Assignment: Extra Credit - Challenge 1 Plane Programming
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float spinSpeed = 450f;

    void Start()
    {

    }
    void Update()
    {
        transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime); // Rotate every frame around the Z axis
    }
}