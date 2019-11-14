﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        playercontrollerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

    // Update is called once per frame
    public GameObject obstacle;
    private Vector3 spawnpos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playercontrollerScript;

    void SpawnObstacle()
    {
        if (playercontrollerScript.gameOver == false)
        {
            Instantiate(obstacle, spawnpos, obstacle.transform.rotation);
        }
        
    }
    void Update()
    {
        
    }
}
