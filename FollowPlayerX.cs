using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
/*{
    public GameObject Player;
    //private Vector3 offset = new Vector3(26.76f,2.12f, -23.33f);
    Vector3 originalCamPos;

    public Transform targetObject; 
    private Vector3 initalOffset;
    private Vector3 cameraPosition;

    void Start()
    {
        initalOffset = transform.position - targetObject.position;
    }

    void FixedUpdate()
    {
        cameraPosition = targetObject.position + initalOffset;
        transform.position = cameraPosition;
    }
}
