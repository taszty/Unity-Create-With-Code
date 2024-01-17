using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class SpinPropellorX : MonoBehaviour
{
    public GameObject propellor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propellor.transform.Rotate(new Vector3(0, 0, 500) * Time.deltaTime);
    }
}
