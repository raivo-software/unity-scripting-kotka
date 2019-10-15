using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    public Collider LeftSphere;
    public Collider RightSphere;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            bool hitSuccesful = Physics.Raycast(ray, out hitInfo);
            if(hitSuccesful)
            {
                Collider other = hitInfo.collider;
                if (other == LeftSphere)
                {
                    Destroy(other.gameObject);
                }
                if (other == RightSphere)
                {
                    Destroy(other.gameObject);
                }
            }
        }
    }
}
