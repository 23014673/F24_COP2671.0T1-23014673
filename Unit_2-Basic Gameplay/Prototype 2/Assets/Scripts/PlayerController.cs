using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    public float horizontalInput;

    public float speed = 10.0f;

    //public float leftBoundry = -30.0f;

    //public float rightBoundry = 30.0f;

    public float xRange = 20;

    public GameObject projectilePrefab;

    void Start()
    {
        
    } 

    void Update()
    {
    // Keep the player in bounds

        if (transform.position.x < -xRange)
        {
            transform.position = new UnityEngine.Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new UnityEngine.Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizontalInput =  Input.GetAxis("Horizontal");

        transform.Translate(UnityEngine.Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
    //Lauch a projectile from the player

            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
