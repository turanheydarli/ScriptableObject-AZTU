using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private FloatingJoystick floatingJoystick;
    [SerializeField] private float speed;
    [SerializeField] private float smoothTurnTime;

    private Rigidbody _rigidbody;
    private Vector3 _direction;
    private float _currentTurnAngle;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _direction = new Vector3(floatingJoystick.Horizontal, 0, floatingJoystick.Vertical);


        if (_direction.magnitude > 0.01f)
        {
            float targetAngle = Mathf.Atan2(_direction.x, _direction.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref _currentTurnAngle,
                0.3f);

            transform.rotation = Quaternion.Euler(0, angle, 0);

            _rigidbody.MovePosition(transform.position + (_direction.normalized * (speed * Time.deltaTime)));
        }
    }
}