using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    Transform playerBody;

    public float mouseSensitivity = 10f;
    public float leeway = 35f;
    float original_angle;

    float pitch = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerBody = transform.parent.transform;

        original_angle = playerBody.eulerAngles.y;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float moveY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        //yaw
        Vector3 e = playerBody.eulerAngles;
        e.y = Mathf.Clamp(e.y + moveX, original_angle - leeway, leeway + original_angle);
        playerBody.eulerAngles = e;
        
        

            //pitch
        pitch -= moveY;
        pitch = Mathf.Clamp(pitch, -90f, 90f);
        transform.localRotation = Quaternion.Euler(pitch, 0, 0);
    }
}
