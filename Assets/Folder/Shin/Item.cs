using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public abstract class Item : MonoBehaviour
{
    [SerializeField]
    protected float _speed = 1f;
    public abstract void Use(in Player player);
}
