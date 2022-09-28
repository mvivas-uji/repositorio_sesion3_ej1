using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Aquí se define la clase "propeller" y sus animaciones
public class Propeller : MonoBehaviour
{
    public float propSpeed;

    // Start is called before the first frame update
    void Start()
    {
        propSpeed = 5000;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * propSpeed * Time.deltaTime);
    }
}
