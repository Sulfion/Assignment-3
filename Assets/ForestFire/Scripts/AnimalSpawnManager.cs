using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnManager : MonoBehaviour
{
    private ForestFire3D forestFire3D;
    public GameObject animalPrefab;

    //variables used for generating random spawn positions.
    //X&Z board size from ForeFire3D script are not stored, so needed to make own
    private float spawnRangeZ = 157.0f;
    private float spawnRangeX = 157.0f;
    private float spawnPosY = 0.7f;
    private float minSpawnRange = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomAnimal();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //create random spawn position for animal to spawn at
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(minSpawnRange, spawnRangeX);
        float spawnPosZ = Random.Range(minSpawnRange, spawnRangeZ);

        Vector3 randomPos = new Vector3(spawnPosX, spawnPosY, spawnPosZ);

        return randomPos;
    }

    //instantiate animal at generated random spawn position
    void SpawnRandomAnimal()
    {
        Instantiate(animalPrefab, GenerateSpawnPosition(), animalPrefab.transform.rotation);
        Instantiate(animalPrefab, GenerateSpawnPosition(), animalPrefab.transform.rotation);
    }
}
