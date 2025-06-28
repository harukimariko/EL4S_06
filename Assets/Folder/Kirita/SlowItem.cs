using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowItem : Item
{
    [SerializeField]
    private float _slowAmount = 0.5f;
    [SerializeField]
    private float _duration = 5f;

    public override void Use(in Player player)
    {
        StartCoroutine(Return(player));
    }

    private IEnumerator Return(Player player)
    {
        float oldSpeed = player._speedRatio;
        player._speedRatio = _slowAmount;
        yield return new WaitForSeconds(_duration);
        player._speedRatio = oldSpeed;

        Destroy(gameObject);
    }
}
