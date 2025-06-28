using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private Vector3 _speed = Vector3.one;
    private Rigidbody _rigidbody;
    public bool _isReverse = false;    // ���]�̃t���O

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    public Rigidbody Rigidbody => _rigidbody;

    /// <summary>
    /// �v���C���[�̈ړ����x
    /// </summary>
    public Vector2 Speed
    {
        get => _speed;
        set => _speed = value;
    }

    // �y��
    [Header("����֘A")]
    [SerializeField] Vector3 _addForce = Vector3.zero;
    [SerializeField, Range(0.0f, 20.0f)] float _speedRatio = 5.0f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // ��F�L�����̈ړ��Ɏg��
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * _speedRatio * Time.deltaTime);
    }

    private void FixedUpdate()
    {

    }
}
