using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody), typeof(BoxCollider))]
public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public bool _isReverse = false;     // ���]�̃t���O
    public int _direction = 1;

    public Item _currentItem = null;    // �A�C�e��

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public Rigidbody Rigidbody => _rigidbody;


    // �y��
    [Header("����֘A")]
    [Range(0.0f, 20.0f)] public float _speedRatio = 3.0f;
    [SerializeField, Range(0.0f, 5.0f)] public float _jumpRatio = 1.0f;
    [SerializeField] private bool _isPlayer1; // �A�C�e���̎Q��
    private KeyCode _playerDown;
    private KeyCode _playerUp;
    private KeyCode _playerLeft;
    private KeyCode _playerRight;
    private KeyCode _playerUseItem; // �A�C�e���g�p�̃L�[

    private void Start()
    {
        if (_isPlayer1)
        {
            _playerDown = KeyCode.S;
            _playerUp = KeyCode.W;
            _playerLeft = KeyCode.A;
            _playerRight = KeyCode.D;
            _playerUseItem = KeyCode.R; // �A�C�e���g�p�̃L�[��ݒ�
        }
        else
        {
            _playerDown = KeyCode.DownArrow;
            _playerUp = KeyCode.UpArrow;
            _playerLeft = KeyCode.LeftArrow;
            _playerRight = KeyCode.RightArrow;
            _playerUseItem = KeyCode.M; // �A�C�e���g�p�̃L�[��ݒ�
        }
    }


    private void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(_playerRight))
        {
            direction.x += 1;
        }
        if (Input.GetKey(_playerLeft))
        {
            direction.x += -1;
        }
        if (Input.GetKey(_playerUp))
        {
            direction.z += 1;
        }
        if (Input.GetKey(_playerDown))
        {
            direction.z += -1;
        }
        direction.x *= _direction; // ���]�̕�����K�p
        direction.z *= _direction; // ���]�̕�����K�p
        direction = direction.normalized * _speedRatio * Time.deltaTime; // ���x��K�p

        // ��F�L�����̈ړ��Ɏg��

        _rigidbody.AddForce(direction, ForceMode.VelocityChange);

        //_rigidbody.velocity += velocity;

        //if (Input.GetKeyDown(KeyCode.U)) JumpForce(3.0f);

        if (Input.GetKeyDown(_playerUseItem))
        {
            UseItem();
        }
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

    public void UseItem()
    {
        if (_currentItem != null)
        {
            _currentItem.Use(this);
            _currentItem = null; // �A�C�e�����N���A
        }
    }
}
