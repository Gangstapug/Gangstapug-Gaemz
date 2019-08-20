using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] bool isGrounded = true;
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
        Jump();




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
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            isGrounded = false;
            rb.AddForce(0, jumpForce, 0);
        }
        else if(isGrounded == false)
        {
            rb.AddForce(0, 0, 0);
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;   
    }

}
