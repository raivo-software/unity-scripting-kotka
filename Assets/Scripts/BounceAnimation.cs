using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAnimation : MonoBehaviour
{
    private Vector3 movement = Vector3.up;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 1)
        {
            movement = Vector3.down;
        }
        else if(transform.position.y < -1)
        {
            movement = Vector3.up;
        }
        transform.Translate(movement * Time.deltaTime);
    }
}
