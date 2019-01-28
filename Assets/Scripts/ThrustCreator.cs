using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrustCreator : MonoBehaviour
{

    public bool applyThrust = false;
    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
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
