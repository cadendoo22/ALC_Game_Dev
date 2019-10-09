using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 50f;
    public float xLimit = 10f;
    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    
    {

        if (transform.position.x < -xLimit)
        {
            transform.position = new Vector3(-xLimit, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xLimit)
        {
            transform.position = new Vector3(xLimit, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * Time.deltaTime* horizontalInput * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //When space is pressed
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
