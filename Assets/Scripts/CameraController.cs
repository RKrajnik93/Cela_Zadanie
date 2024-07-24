using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 100f;

    float xRotation = 0f;
    float yRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation += mouseX;
        yRotation -= mouseY;        

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
