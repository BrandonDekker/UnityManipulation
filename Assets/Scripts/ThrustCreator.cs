using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// attach this script to the object that is having thrust applied to it. thrust must counter act the gravity.
/// change the thrust button by changing the getkey keycode 
/// 
/// </summary>

public class ThrustCreator : MonoBehaviour
{
    //change the thrust in the unity editor to match the mass of the object being moved
    public bool applyThrust = false;
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // used to reset the position of an object if it gets lost. for testing purposes only
        if (Input.GetKey(KeyCode.R))
        {
            transform.position = new Vector3(0.0f, 2.0f, 0.0f);
            transform.rotation = Quaternion.identity;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            applyThrust = true;
        }
        else
        {
            applyThrust = false;
        }
        if (applyThrust)
        {
            rb.AddForce(transform.up * thrust);
        }
    }
    // Start is called before the first frame update
   
    // Update is called once per frame

}
