using UnityEngine;

public class Dragon : EnemyMonoBase
{
    private Rigidbody _rigidbody;
    private Vector3 _direction;
    private PlayerController _player;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _player = FindObjectOfType<PlayerController>();
    }

    private void Update()
    {
        transform.LookAt(_player.transform);
        _direction = _player.transform.position - transform.position;

        if (Vector3.Distance(_player.transform.position, transform.position) > 2)
        {
            _rigidbody.MovePosition(transform.position + _direction * (speed * Time.deltaTime));
        }
    }
}