using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mooncontroller : MonoBehaviour
{
   
    public Transform targetObject;
    public float rotationSpeed;

    void Update()
    {
        
        transform.RotateAround(targetObject.position, targetObject.up, rotationSpeed * Time.deltaTime);
    }
}
