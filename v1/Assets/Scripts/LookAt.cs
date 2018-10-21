using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    private Touch initTouch = new Touch();

    private const float Y_ANGLE_MIN = 0.0f;
    private const float Y_ANGLE_MAX = 50.0f;
    public Transform lookAt;
    public Transform camTransform;

    public float rotationSpeed = 0.5f;
    public float dir = -1;

    private Camera cam;

    private float distance = 30.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;
    private float sensitivityX = 1.0f;
    private float sensitivityY = 1.0f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;

    }


    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentX, currentY, 0f);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }

    void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                initTouch = touch;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                //swiping
                float deltaX = initTouch.position.x - touch.position.x;
                float deltaY = initTouch.position.y - touch.position.y;
                currentX += deltaY * Time.deltaTime * rotationSpeed * dir;
                currentY += deltaX * Time.deltaTime * rotationSpeed * dir;
                cam.transform.eulerAngles = new Vector3(currentX, currentY, 0f);

            }
            else if (touch.phase == TouchPhase.Ended)
            {
                initTouch = new Touch();
            }
        }


    }
}
