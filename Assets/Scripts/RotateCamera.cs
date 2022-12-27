using System.Collections;
using System.Collections.Generic;

using UnityEngine;

//Attach this script to a GameObject to rotate around the target position.
public class RotateCamera : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    public GameObject camera;
    private bool notRotating;

    public void Rotate()
    {
        notRotating = false;
        StartCoroutine("rotateCamera");
    }

    public void Update(){
        
        if(notRotating){
            
            camera.transform.rotation = Quaternion.Euler(17, 0, 0);
        }
    }
    

    IEnumerator rotateCamera()
    {
        float holder = 0;
        while (holder < 5)
        {
            holder += 1 * Time.deltaTime;
            camera.transform.RotateAround(target.transform.position, Vector3.up, 70 * Time.deltaTime);
            camera.transform.position += new Vector3(0, -3 * Time.deltaTime, 0);
            camera.transform.position +=  camera.transform.forward * 8 * Time.deltaTime;
            yield return 0;
        }
        camera.transform.position = new Vector3(0,15,-10);
        camera.transform.rotation = Quaternion.Euler(17, 0, 0);
        notRotating = true;
        yield return true;
    }
 
}
