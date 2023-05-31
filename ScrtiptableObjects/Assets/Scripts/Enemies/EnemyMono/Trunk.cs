using System;
using DG.Tweening;
using UnityEngine;

public class Trunk : EnemyMonoBase
{
    [SerializeField] private float jumpCooldown;

    private PlayerController _playerController;
    private float nextJumpTime;

    private void Start()
    {
        _playerController = FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        if (Time.time >= nextJumpTime)
        {
            Jump();

            nextJumpTime = Time.time + jumpCooldown;
        }
    }

    private void Jump()
    {
        transform.DOJump(_playerController.transform.position, 2f, 1, 1f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out IDestructible destructible))
        {
            destructible.TakeDamage(damage);
        }
    }
}