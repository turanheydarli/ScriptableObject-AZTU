using UnityEngine;

public abstract class EnemyBaseSO : ScriptableObject
{
    public float health;
    public float attackRate;
    public float speed;
    public float damage;
    public Transform enemyPrefab;
    public abstract void Spawn(Transform caster);
}