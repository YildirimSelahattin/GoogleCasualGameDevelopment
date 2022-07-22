using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCam : MonoBehaviour
{
    [SerializeField] private Transform _sunTransform;
    [SerializeField] private float _startingRotateSpeedAroundSun;
    [SerializeField] private float _fasterRotateSpeedAroundSun;
    Camera _mainCamera;

    private void Start()
    {
        _mainCamera = Camera.main;
    }

    private void LateUpdate()
    {
        //Sürekli dönme
        transform.RotateAround(_sunTransform.position, Vector3.up, _startingRotateSpeedAroundSun * Time.deltaTime);

        //Mouse'nýn sol tuluþa basýlý tutup döndürme
        if (Input.GetMouseButton(0))
            transform.RotateAround(_sunTransform.transform.position, Vector3.up, Input.GetAxis("Mouse X") * _fasterRotateSpeedAroundSun);
    }
}
