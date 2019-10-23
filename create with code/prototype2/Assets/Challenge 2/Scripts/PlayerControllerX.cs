using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public int cooldown;
    // Update is called once per frame
    void Update()
    {
        cooldown += 1;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldown > 30)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown = 0;
        }
    }
}
