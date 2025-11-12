using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform spawnPosition;

    public void SpawnCube()
    {
        Vector3 randomPos = new Vector3(Random.Range(-5f, 5f), 0.5f , Random.Range(-5f, 5f));

        Instantiate(cubePrefab, randomPos, Quaternion.identity);
    }
}
