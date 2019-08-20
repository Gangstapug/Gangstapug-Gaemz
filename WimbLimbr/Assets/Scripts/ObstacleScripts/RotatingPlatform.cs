using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlatform : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RotatePlatform();
    }
    void RotatePlatform()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
