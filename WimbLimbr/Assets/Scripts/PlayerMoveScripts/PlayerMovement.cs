using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] bool isGrounded = false;
    [SerializeField] float jumpForce = 500f;


    [SerializeField] float MouseSpeed = 75f;
    [SerializeField] float playerSpeed = 10f;
 

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        HorizontalRotation();
        
        Movement();
    }
    void Movement()
    {
        float xInput = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float zInput = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        Vector3 newPosition = transform.position + (transform.forward * zInput) + (transform.right * xInput);

        rb.MovePosition(newPosition);
     

    }
    void HorizontalRotation()
    {
        float yRotation = Input.GetAxis("Mouse X") * MouseSpeed * Time.deltaTime;

        transform.Rotate(0, yRotation, 0);
    }

    void Jump()
    {
        rb.AddForce(0, jumpForce, 0);
        Invoke("StopJump", 1f);

    }
    void StopJump()
    {
        rb.AddForce(0, 0, 0);
    }
}
