﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float xSpeed = 3f;
    public static int score;

    void Update()
    {
        //transform.Translate(new Vector3(xSpeed * Time.deltaTime, 0, 0f));
        if (transform.position.x <= -8)
        {
            Destroy(this.gameObject);
            score++;
        }
        else
        {
            transform.Translate(Vector3.right * Time.deltaTime * -xSpeed);
        }            
    }
}
