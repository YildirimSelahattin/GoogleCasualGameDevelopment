using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public float arroundSunSpeed;
    public float planetSpeed;
    public Transform sun;

    void Update()
    {
        //Around the sun
        transform.RotateAround(sun.position, Vector3.up, arroundSunSpeed * Time.deltaTime);
        //Around own
        transform.Rotate(Vector3.up * planetSpeed * Time.deltaTime);
    }

}
