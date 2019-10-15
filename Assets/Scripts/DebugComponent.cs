using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugComponent : MonoBehaviour
{
    public GameObject Sphere;
    private Vector3 movement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting script");
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("w"))
        {
            movement = movement + Vector3.forward;
        }
        if(Input.GetKeyUp("w"))
        {
            movement = movement - Vector3.forward;
        }
        if (Input.GetKeyDown("s"))
        {
            movement = movement + Vector3.back;
        }
        if (Input.GetKeyUp("s"))
        {
            movement = movement - Vector3.back;
        }

        Sphere.transform.Translate((movement * 5) * Time.deltaTime);
    }
}
