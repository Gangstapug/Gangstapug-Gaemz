using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMouseLook : MonoBehaviour
{
    [SerializeField] float verticalMouseSpeed = 30f;
    [SerializeField] float xAxisClamp = 0f;


    private void Awake()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       VerticalMouse();
    }

    void VerticalMouse()
    {
        float mouseY = Input.GetAxis("Mouse Y") * verticalMouseSpeed * Time.deltaTime;
        xAxisClamp += mouseY;

        if(xAxisClamp > 90f)
        {
            xAxisClamp = 90f;
            mouseY = 0f;
            clampXAxisRotationToValue(270f);
        }
        else if (xAxisClamp < -90f)
        {
            xAxisClamp = -90f;
            mouseY = 0f;
            clampXAxisRotationToValue(90f);
        }

        transform.Rotate(-mouseY, 0, 0);
    }

    void clampXAxisRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
