using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    // this variable is used for attaching the game object 
    public GameObject planetObject;
    public Vector3 RotationVector;

    // Update is called once per frame
    void Update()
    {
        planetObject.transform.Rotate(RotationVector * Time.deltaTime);
    }
}
