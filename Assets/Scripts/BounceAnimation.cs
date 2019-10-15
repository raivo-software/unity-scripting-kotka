using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceAnimation : MonoBehaviour
{
    public Collider LeftSphere;
    public Collider RightSphere;

    private Vector3 movement = Vector3.left;
    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > 1)
        {
            movement = Vector3.left;
        }
        else if(transform.position.x < -1)
        {
            movement = Vector3.right;
        }
        transform.Translate(movement * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == LeftSphere)
            Debug.Log("Collided with left sphere");
        else if (other == RightSphere)
            Debug.Log("Collided with right sphere");
    }
}
