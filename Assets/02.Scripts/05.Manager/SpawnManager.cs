using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("MovingEnemy")]
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private BoxCollider spawnPoint;
    [SerializeField] private float spawnInterval = 3f;

    private void Awake()
    {
        InvokeRepeating(nameof(SpawnMovingEnemy), 0f, spawnInterval);
    }

    private void SpawnMovingEnemy()
    {
        Vector3 spawnPos = GetRandomSpawnPosition();
        Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);
    }
    private Vector3 GetRandomSpawnPosition()
    {
        float xPos = Random.Range(spawnPoint.bounds.min.x, spawnPoint.bounds.max.x);
        float zPos = Random.Range(spawnPoint.bounds.min.z, spawnPoint.bounds.max.z);
        return new Vector3(xPos, spawnPoint.bounds.center.y, zPos);
    }

}
