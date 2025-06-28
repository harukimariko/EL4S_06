using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpItem : Item
{
    [SerializeField]
    private float _jumpForce = 5f;

    public override void Use(in Player player)
    {
       player.JumpForce(_jumpForce);

        Destroy(gameObject);
    }
}
