using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLap : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Lap control with OnTrigger
        if (other.gameObject.tag == "Earth")
        {
            Debug.Log($"Complete Earth");
        }
        if (other.gameObject.tag == "Mars")
        {
            Debug.Log($"Complete Mars");

        }
    }
}
