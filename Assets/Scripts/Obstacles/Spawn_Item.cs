using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Item : MonoBehaviour
{
    private bool canSpawnCar;

    [SerializeField] private float[] spawnCarTime;
    [SerializeField] private GameObject[] cars;

    void Start()
    {
        StartCoroutine(SpawnCarRoutine());
    }

    void Update()
    {
        SpawnCars();
    }

    private void SpawnCars()
    {
        if(canSpawnCar) 
        {
            Instantiate(cars[Random.Range(0, cars.Length)], transform.position, Quaternion.identity);
            StartCoroutine(SpawnCarRoutine());
        }
    }

    IEnumerator SpawnCarRoutine()
    {
        canSpawnCar = false;
        yield return new WaitForSeconds(spawnCarTime[Random.Range(0, spawnCarTime.Length)]);
        canSpawnCar = true;
    }
}
