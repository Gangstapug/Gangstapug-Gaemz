using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMouseLook : MonoBehaviour
{
    [SerializeField] float verticalMouseSpeed = 30f;

    Vector2 rotation = new Vector2(0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       VerticalMouse();
    }
    void VerticalMouse()
    {
        

        float yMouse = Input.GetAxis("Mouse Y") * verticalMouseSpeed * Time.deltaTime;
        transform.Rotate(-yMouse, 0, 0);
        Cursor.lockState = CursorLockMode.Locked;
        
    }
}
