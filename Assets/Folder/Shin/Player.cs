using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

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
    [Range(0.0f, 20.0f)] public float _speedRatio = 3.0f;
    [SerializeField, Range(0.0f, 5.0f)] public float _jumpRatio = 1.0f;
    [SerializeField] private bool _isPlayer1; // アイテムの参照
    private KeyCode _playerDown;
    private KeyCode _playerUp;
    private KeyCode _playerLeft;
    private KeyCode _playerRight;
    private KeyCode _playerUseItem; // アイテム使用のキー

    private void Start()
    {
        if (_isPlayer1)
        {
            _playerDown = KeyCode.S;
            _playerUp = KeyCode.W;
            _playerLeft = KeyCode.A;
            _playerRight = KeyCode.D;
            _playerUseItem = KeyCode.R; // アイテム使用のキーを設定
        }
        else
        {
            _playerDown = KeyCode.DownArrow;
            _playerUp = KeyCode.UpArrow;
            _playerLeft = KeyCode.LeftArrow;
            _playerRight = KeyCode.RightArrow;
            _playerUseItem = KeyCode.M; // アイテム使用のキーを設定
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
        direction.x *= _direction; // 反転の方向を適用
        direction.z *= _direction; // 反転の方向を適用
        direction = direction.normalized * _speedRatio * Time.deltaTime; // 速度を適用

        // 例：キャラの移動に使う

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
            _currentItem = null; // アイテムをクリア
        }
    }
}
