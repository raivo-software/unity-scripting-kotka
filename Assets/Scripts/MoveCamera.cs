using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private Vector3 startPosition;
    private Vector3 mouseStartPosition;
    private Vector3 mouseStartPosition2;

    private void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.mouseScrollDelta.magnitude > 0)
        {
            transform.position = transform.position + (new Vector3(0, 0, Input.mouseScrollDelta.y));
        }

        if(Input.GetMouseButtonDown(0))
        {
            transform.position = startPosition;
        }

        if(Input.GetMouseButtonDown(1))
        {
            mouseStartPosition = Input.mousePosition;
        }

        if(Input.GetMouseButton(1))
        {
            Vector3 mousePositionDelta = mouseStartPosition - Input.mousePosition;
            mouseStartPosition = Input.mousePosition;
            //transform.eulerAngles = transform.eulerAngles + new Vector3(mousePositionDelta.y, mousePositionDelta.x, 0);
            
            transform.forward = transform.forward + (mousePositionDelta / 1000);
        }
    }
}
