using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    public float rotationSpeed = 50f;
    Vector3 rotateVelocity;

    // Update is called once per frame
    void Update()
    {
        var crInput = Input.GetAxis("CameraRotation");

        rotateVelocity = transform.up * rotationSpeed * crInput;

        transform.Rotate(rotateVelocity * Time.deltaTime);
    }
}
