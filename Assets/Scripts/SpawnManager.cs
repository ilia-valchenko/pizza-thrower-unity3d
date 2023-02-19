using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private const float SpawnRangeX = 20.0f;
    private const float SpawnPositionZ = 20.0f;
    private const int StartDelay = 2;
    private const float SpawnInterval = 1.5f;

    public GameObject[] animalsPrefabs;

    // Start is called before the first frame update
    void Start()
    {
        this.InvokeRepeating("SpawnRandonAnimal", StartDelay, SpawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandonAnimal()
    {
        int animalIndex = Random.Range(0, this.animalsPrefabs.Length);
        var spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPositionZ);

        // static method of the Object type
        if (this.animalsPrefabs.Length > animalIndex && this.animalsPrefabs[animalIndex] != null)
        {
            Instantiate(this.animalsPrefabs[animalIndex], spawnPos, this.animalsPrefabs[animalIndex].transform.rotation);
        }
    }
}
