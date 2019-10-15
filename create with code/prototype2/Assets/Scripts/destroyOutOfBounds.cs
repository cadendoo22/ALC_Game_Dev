using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutOfBounds : MonoBehaviour
{
    public float topLimit = 30f;
    public float lowerBounds = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topLimit)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds)
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }

    }
}
