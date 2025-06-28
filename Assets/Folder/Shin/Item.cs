using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public abstract class Item : MonoBehaviour
{
    [SerializeField]
    protected float _speed = 1f;
    [SerializeField]
    protected Sprite _icon;

    private BoxCollider _boxCollider;
    private MeshRenderer _meshRenderer;

    public abstract void Use(in Player player);

    private void Reset()
    {
        BoxCollider boxCollider = GetComponent<BoxCollider>();
        boxCollider.isTrigger = true;
    }

    private void Awake()
    {
        _boxCollider = GetComponent<BoxCollider>();
        _boxCollider.isTrigger = true;
        _meshRenderer = GetComponentInChildren<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<Player>(out var player))
        {
            if (player._currentItem != null)
            {
                Destroy(gameObject);
                return;
            }

            _boxCollider.enabled = false;
            _meshRenderer.enabled = false;

            player._currentItem = this; // アイテムをプレイヤーにセット
            transform.SetParent(other.transform);
            _speed = 0f;
        }

        if(other.CompareTag("Finish"))
        {
            Destroy(gameObject);
        }
    }

    protected virtual void Update()
    {
        transform.Translate(Vector3.back * _speed * Time.deltaTime);
    }   

    public Sprite Icon => _icon;
}
