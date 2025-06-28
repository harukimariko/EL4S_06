using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public bool _isReverse = false;     // 反転のフラグ
    public int _direction = 1;

    public Item _currentItem = null;    // アイテム

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public Rigidbody Rigidbody => _rigidbody;


    // 惣佐
    [Header("操作関連")]
    [Range(0.0f, 10.0f)] public float _speedRatio = 3.0f;
    [SerializeField, Range(0.0f, 5.0f)] public float _jumpRatio = 1.0f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal") * _direction;
        float vertical = Input.GetAxis("Vertical") * _direction;

        // 速度の保存
        Vector3 velocity = _rigidbody.velocity;

        // 例：キャラの移動に使う
        Vector3 direction = new Vector3(horizontal, 0, vertical) * _speedRatio;
        _rigidbody.AddForce(direction, ForceMode.Acceleration);

        _rigidbody.velocity += velocity;

        if (Input.GetKeyDown(KeyCode.U)) JumpForce(3.0f);

    }

    public void JumpForce(float force)
    {
        Vector3 jumpForce = new Vector3(0.0f, force, 0.0f);
        _rigidbody.AddForce(jumpForce, ForceMode.Impulse);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {

        }
    }
}
