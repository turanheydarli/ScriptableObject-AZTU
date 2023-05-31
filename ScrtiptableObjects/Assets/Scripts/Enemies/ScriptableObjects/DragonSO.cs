using UnityEngine;

[CreateAssetMenu(fileName = "New Dragon", menuName = "Enemies/Dragon")]
public class DragonSO : EnemyBaseSO
{
    public override void Spawn(Transform caster)
    {
        var enemy = Instantiate(enemyPrefab, caster.position, Quaternion.identity);

        EnemyMonoBase dragon = enemy.GetComponent<EnemyMonoBase>();

        dragon.damage = damage;
        dragon.health = health;
        dragon.attackRate = attackRate;
        dragon.speed = speed;
    }
}