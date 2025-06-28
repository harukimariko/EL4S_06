using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody),typeof(BoxCollider))]
public class Player : MonoBehaviour
{
    [SerializeField]
    private Vector2 _speed = Vector2.one;
    private Rigidbody _rigidbody;

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
}
