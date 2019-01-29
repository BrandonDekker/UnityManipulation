using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public bool right = false, left = false, forward = false, backward = false;
    public float RotationMultiplier = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        right = false;
        left = false;
        forward = false;
        backward = false;
        if (Input.GetKey(KeyCode.W))
        {
            forward = true;
            transform.Rotate(Vector3.forward * Time.deltaTime * RotationMultiplier);
        }
        if (Input.GetKey(KeyCode.S)) 
        {
            backward = true;
            transform.Rotate(Vector3.back * Time.deltaTime * RotationMultiplier);
        }
        if (Input.GetKey(KeyCode.A))
        {
            left = true;
            transform.Rotate(Vector3.left * Time.deltaTime * RotationMultiplier);
        }
        if (Input.GetKey(KeyCode.D))
        {
            right = true;
            transform.Rotate(Vector3.right * Time.deltaTime * RotationMultiplier);
        }

        if (forward)
        {
            transform.Rotate(Vector3.up * Time.deltaTime);
        }
        if (backward)
        {
            transform.Rotate(Vector3.down * Time.deltaTime);
        }
        if (left)
        {
            transform.Rotate(Vector3.left * Time.deltaTime);
        }
        if (right)
        {
            transform.Rotate(Vector3.right * Time.deltaTime);
        }
    }
}
