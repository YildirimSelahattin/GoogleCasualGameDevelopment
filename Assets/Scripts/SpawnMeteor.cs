using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]

public class SpawnMeteor : MonoBehaviour
{
    private Rigidbody _meteorRigidbody;
    private TrailRenderer _trailRenderer;
    
    [SerializeField] private float _meteorFollowSpeed;
    [SerializeField] private float _meteorThrowSpeed;
    [SerializeField] private GameObject[] _planets;

    public GameObject[] Planets { get { return _planets; } private set { _planets = value; } }
    private int randomIndex;
    private float _destroyTime = 0;

    private void Awake()
    {
        _meteorRigidbody = GetComponent<Rigidbody>();
        _planets = Planets;
    }

    private void Start()
    {
        randomIndex = Random.Range(0, 4);
    }
    private void Update()
    {
        MeteorFollowingToPlanet();
        ThrowMeteorToPlanet();
    }

    private void MeteorFollowingToPlanet()
    {
        //Meteorlarýn gezegene doðru gelmesini saðlýyor
        transform.position = Vector3.MoveTowards(transform.position, _planets[randomIndex].transform.position, _meteorFollowSpeed * Time.deltaTime);
    }

    private void ThrowMeteorToPlanet()
    {
        Vector3 _distance = _planets[randomIndex].transform.position - transform.position;
        _meteorRigidbody.AddForce(_distance.normalized * _meteorThrowSpeed);
        _destroyTime += Time.deltaTime;
        if (_destroyTime > 3f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;

        StartCoroutine(StopExplosionCoroutine());
    }

    IEnumerator StopExplosionCoroutine()
    {
        yield return new WaitForSeconds(2);

        Destroy(gameObject);
    }
}
