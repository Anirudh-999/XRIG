using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetcontroller : MonoBehaviour

{

    public float angularvelocity = 5f;

    public float rotationSpeed;

    public Transform targetObject;


    void Start()
    {
        
    }
    void Update()
    {   
        transform.Rotate(Vector3.up, angularvelocity*Time.deltaTime);

        transform.RotateAround(targetObject.position, targetObject.up, rotationSpeed * Time.deltaTime);
    }
}
