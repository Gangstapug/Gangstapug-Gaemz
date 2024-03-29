﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingWall : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 30f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        WallRotation();
    }
    void WallRotation()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);
    }
}
