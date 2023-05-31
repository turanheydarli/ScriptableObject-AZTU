using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private List<EnemyBaseSO> enemies;

    private void Start()
    {
        StartCoroutine(SpawnRandomEnemy());
    }

    IEnumerator SpawnRandomEnemy()
    {
        while (true)
        {
            EnemyBaseSO randomEnemy = enemies[Random.Range(0, enemies.Count)];

            randomEnemy.Spawn(transform);

            yield return new WaitForSeconds(3f);
        }
    }
}