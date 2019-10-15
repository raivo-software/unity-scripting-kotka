using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugComponent : MonoBehaviour
{
    private GameObject Sphere1;
    private GameObject Sphere2;
    private GameObject Sphere3;

    private GameObject TargetSphere;

    private Vector3 movement = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Starting script");
        Sphere1 = GameObject.FindWithTag("Sphere");
        Sphere2 = GameObject.FindWithTag("Sphere2");
        Sphere3 = GameObject.FindWithTag("Sphere3");
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

        if(TargetSphere != null)
        {
            TargetSphere.transform.Translate((movement * 5) * Time.deltaTime);
        }

        if(Input.GetKeyDown("1"))
        {
            Sphere1.SetActive(true);
            Sphere2.SetActive(false);
            Sphere3.SetActive(false);
            TargetSphere = Sphere1;

            if(Sphere1.GetComponents<BounceAnimation>().Length == 0)
            {
                Sphere1.AddComponent<BounceAnimation>();
            }
        }
        if (Input.GetKeyDown("2"))
        {
            Sphere2.SetActive(true);
            Sphere1.SetActive(false);
            Sphere3.SetActive(false);
            TargetSphere = Sphere2;

            if (Sphere2.GetComponents<BounceAnimation>().Length == 0)
            {
                Sphere2.AddComponent<BounceAnimation>();
            }
        }
        if (Input.GetKeyDown("3"))
        {
            Sphere3.SetActive(true);
            Sphere2.SetActive(false);
            Sphere1.SetActive(false);
            TargetSphere = Sphere3;

            if (Sphere3.GetComponents<BounceAnimation>().Length == 0)
            {
                Sphere3.AddComponent<BounceAnimation>();
            }
        }
    }
}
