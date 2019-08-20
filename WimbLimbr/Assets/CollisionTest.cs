using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    [SerializeField] bool jumpCheck = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        CheckIfGrounded();
    }
    private void OnCollisionEnter(Collision collision)
    {
        jumpCheck = true;
        print("collided");
    }
    void CheckIfGrounded()
    {
        if (Input.GetButtonDown("Jump") && jumpCheck == true)
        {
            SendMessageUpwards("Jump");
            jumpCheck = false;
            print("Jump has been pressed");
        }
    }
}
