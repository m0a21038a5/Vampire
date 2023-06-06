using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Transform player;
    [SerializeField]
    List<GameObject> enemylist = new List<GameObject>();
    [SerializeField]
    float spawnRadius = 10f;
    [SerializeField]
    public float spawnInterval;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnEnemy();
            timer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Vector3 randomPosition = GetRandomPosition();
        int enemy = Random.Range(0, 2);
        Instantiate(enemylist[enemy], randomPosition, Quaternion.identity);
    }

    Vector3 GetRandomPosition()
    {
        Vector2 randomCircle = Random.insideUnitCircle * spawnRadius;
        Vector3 randomPosition = new Vector3(randomCircle.x, 0f, randomCircle.y);
        randomPosition += player.position;

        // ålŒö‚ÌüˆÍ‚É‹ß‚¢ê‡AÄ¶¬‚·‚é
        while (Vector3.Distance(randomPosition, player.position) < 5f)
        {
            randomCircle = Random.insideUnitCircle * spawnRadius;
            randomPosition = new Vector3(randomCircle.x, 0f, randomCircle.y);
            randomPosition += player.position;
        }

        return randomPosition;
    }
}
