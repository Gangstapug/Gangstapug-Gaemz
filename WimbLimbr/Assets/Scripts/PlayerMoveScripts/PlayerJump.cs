using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] bool isGrounded = true;
    

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        JumpButton();
    }
    void OnCollisionEnter(Collision collision)
    {
        print("ISgROUNDED");

        isGrounded = true; //lets you knwo you're able to do a jump
    }
    void JumpButton()
    { 
       if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            isGrounded = false; //Cant do a double Jump
            SendMessageUpwards("EnableJump");
  
        }
       else if(isGrounded == false)
        {
            SendMessageUpwards("DisableJump");
        }
    }
}
