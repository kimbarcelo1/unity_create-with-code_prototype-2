using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] animals;
    private float xRange = 20.0f;
    private float zRange = 20.0f;
    private float startDelay = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", startDelay, Random.Range(1, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimals()
    {
        int random = Random.Range(0, animals.Length);
        Vector3 position = new Vector3(Random.Range(-xRange, xRange), transform.position.y, zRange);
        Instantiate(animals[random], position, animals[random].transform.rotation);
    }
}
