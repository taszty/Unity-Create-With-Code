    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    public float speed = 20f;
    public float turnSpeed = 45f;
    public float horInput;
    public float forInput;

    // Update is called once per frame
    void Update()
    {
        // horizontal/vertical input
        horInput = Input.GetAxis("Horizontal");
        forInput = Input.GetAxis("Vertical");
        // move forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forInput);
        // rotate based on horizontal input
        transform.Rotate(Vector3.up, turnSpeed * horInput * Time.deltaTime);
    }
}
