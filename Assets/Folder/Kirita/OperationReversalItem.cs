using System.Collections;
using UnityEngine;

public class OperationReversalItem : Item
{
    [SerializeField]
    private float _duration = 5f;

    public override void Use(in Player player)
    {
        Player target = GameManager.Instance.RightPlayer == player ? GameManager.Instance.LeftPlayer : GameManager.Instance.RightPlayer ;
        StartCoroutine(Return(target));
    }

    private IEnumerator Return(Player player)
    {

        player._isReverse = true;
        player._direction = -player._direction;
        yield return new WaitForSeconds(_duration);
        player._isReverse = false;
        player._direction = -player._direction;

        Destroy(gameObject);
    }
}
