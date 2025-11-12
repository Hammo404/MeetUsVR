using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public Transform spawnPosition;

    //Spawns a new cube instance at a random position on the X-Z plane.
    public void cubeSpawner()
    {
        // Define a random position within a specific X and Z range, keeping Y constant at 0.5f.
        Vector3 randomPos = new Vector3(Random.Range(-5f, 5f), 0.5f , Random.Range(-5f, 5f));

        // Instantiate the cubePrefab at the generated random position with no rotation (Quaternion.identity).
        Instantiate(cubePrefab, randomPos, Quaternion.identity);
    }
}
