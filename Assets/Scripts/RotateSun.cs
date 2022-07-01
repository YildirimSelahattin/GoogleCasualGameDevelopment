using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSun : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //Around own
        transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }
}
