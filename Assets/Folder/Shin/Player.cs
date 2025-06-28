using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private Vector3 _speed = Vector3.one;
    private Rigidbody _rigidbody;
    public bool _isReverse = false;     // 反転のフラグ
    public Item _currentItem = null;    // アイテム

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    public Rigidbody Rigidbody => _rigidbody;

    /// <summary>
    /// プレイヤーの移動速度
    /// </summary>
    public Vector3 Speed
    {
        get => _speed;
        set => _speed = value;
    }

    // 惣佐
    [Header("操作関連")]
    [SerializeField] Vector3 _addForce = Vector3.zero;
    [SerializeField, Range(0.0f, 20.0f)] float _speedRatio = 5.0f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 例：キャラの移動に使う
        Vector3 direction = new Vector3(horizontal, 0, vertical) * _speedRatio;
        transform.Translate(direction * _speedRatio * Time.deltaTime);
        //_rigidbody.AddForce(direction, ForceMode.Acceleration);
    }

    private void FixedUpdate()
    {

    }
}
