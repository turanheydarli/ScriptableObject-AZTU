using UnityEngine;

[CreateAssetMenu(fileName = "New Trunk", menuName = "Enemies/Trunk")]
public class TrunkSO : EnemyBaseSO
{
    public override void Spawn(Transform caster)
    {
        Transform enemy = Instantiate(enemyPrefab, caster.transform.position, Quaternion.identity);

        EnemyMonoBase trunk = enemy.GetComponent<EnemyMonoBase>();

        trunk.damage = damage;
        trunk.health = health;
        trunk.attackRate = attackRate;
        trunk.speed = speed;
    }
}