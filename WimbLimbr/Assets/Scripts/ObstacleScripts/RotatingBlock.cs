using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBlock : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rotation();
    }
    void Rotation()
    {
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
