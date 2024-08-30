/*
Author: Hannah Bauer
Course: COP2671.0T1
Date: 8/30/2024
Assignment: Extra Credit - Challenge 1 Plane Programming
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlane : MonoBehaviour
{
    public Transform player;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player.position;
    }
    
    void LateUpdate()
    {
        // Make the camera follow the plane (so it can follow the code below)
        transform.LookAt(player);

        // Assign the plane variable in the camera’s inspector and assign the offset
        transform.position = player.position + offset;
    }
}