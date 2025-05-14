using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Prefab do inimigo e pontos de spawn")]
    public GameObject[] enemyPrefabs; // Vários inimigos para escolher por wave
    public Transform[] spawnPoints;
    private int currentWave = 1;
    private bool canSpawn = true;

    public void SetWave(int wave)
{
    currentWave = wave;

    // Define um novo intervalo dependendo da wave
    if (wave == 1)
        spawnInterval = 2f;
    else if (wave == 2)
        spawnInterval = 3f;
    else
        spawnInterval = 2f;

    // Reinicia o InvokeRepeating com o novo intervalo
    CancelInvoke();
    InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
}


    public void SetSpawning(bool state)
    {
        canSpawn = state;
    }


    [Header("Intervalo entre spawns")]
    public float spawnInterval = 2f;

    void Start()
    {
        // Começa a spawnar repetidamente
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

   void SpawnEnemy()
{
    if (!canSpawn || enemyPrefabs.Length == 0) return;

    Transform point = spawnPoints[Random.Range(0, spawnPoints.Length)];
    GameObject prefabToSpawn;

    if (currentWave == 1)
    {
        prefabToSpawn = enemyPrefabs[0];
    }
    else if (currentWave == 2 && enemyPrefabs.Length > 1)
    {
        prefabToSpawn = enemyPrefabs[1];
    }
    else if (currentWave == 3 || currentWave == 4)
    {
        // Mistura inimigo 1 e 2 (índices 0 e 1)
        prefabToSpawn = enemyPrefabs[Random.Range(0, 2)];
    }
    else if (currentWave >= 5 && enemyPrefabs.Length >= 3)
    {
        // Mistura inimigo 1, 2 e 3 (índices 0, 1, 2)
        prefabToSpawn = enemyPrefabs[Random.Range(0, 3)];
    }
    else
    {
        // Caso padrão se wave for maior que o esperado
        int maxIndex = Mathf.Min(currentWave - 1, enemyPrefabs.Length - 1);
        prefabToSpawn = enemyPrefabs[maxIndex];
    }

    Instantiate(prefabToSpawn, point.position, Quaternion.identity);
}



}
