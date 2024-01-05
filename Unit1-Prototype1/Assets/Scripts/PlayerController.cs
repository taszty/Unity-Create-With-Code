using System.Collections;


using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables
    public float speed = 20f;

    // Update is called once per frame
    void Update()
    {
        // move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
