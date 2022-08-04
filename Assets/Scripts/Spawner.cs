using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Camera _mainCamera;
    
    [SerializeField] private GameObject _meteorPrefab;
    [SerializeField] private float _radius;
    private Vector3 _randomSpawnPos;

    public void SpawnMeteor()
    {
        //Spawn pos'un i�erisinde random bir yerde meteor prefab� �retiyor
        _randomSpawnPos = Random.insideUnitSphere * _radius;
        Instantiate(_meteorPrefab, _randomSpawnPos, Quaternion.identity);
    }
}
