using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    private float topBound = 30;

    private float lowerBound = -10;

    void Start()
    {
        
    }

    void Update()
    {
        if (transform.position.z > topBound) // If an object goes past the players view in the game, remove that object
        {
            Destroy(gameObject);
        }

        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
