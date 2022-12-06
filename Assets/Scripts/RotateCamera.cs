using System.Collections;
using System.Collections.Generic;

using UnityEngine;

//Attach this script to a GameObject to rotate around the target position.
public class Rotate_Camera : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;

    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.up, 80 * Time.deltaTime);
        //transform.Rotate( Vector3.up, 20 * Time.deltaTime);

    }
}
