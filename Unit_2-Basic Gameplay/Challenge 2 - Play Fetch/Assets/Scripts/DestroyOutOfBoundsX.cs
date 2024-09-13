using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30.0f;    // Destroy DOGS when x < leftLimit
    private float bottomLimit = -10.0f;  // Destroy BALLS when y < bottomLimit

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position is less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position is less than bottom limit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
