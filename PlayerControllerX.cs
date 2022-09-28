using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    //public GameObject Propeller;
    public GameObject Player;
    Vector3 originalPos;

    // Start is called before the first frame update
    void Start()
    {
        //Propeller = gameObject.("Propeller");
        originalPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);

        //Propeller.transform.Rotate(Vector3.forward * 10 * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag ("Respawn"))
        {
            transform.position = originalPos;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            transform.position = originalPos;
        }
    }
}
