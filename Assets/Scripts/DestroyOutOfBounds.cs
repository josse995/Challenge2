using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float xLimitTo = -30;
    private float xLimitFrom = 17;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < xLimitTo || transform.position.x > xLimitFrom)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}