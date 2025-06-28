using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionReversalItem : Item
{
    public override void Use(in Player player)
    {
        Player rp = GameManager.Instance.RightPlayer;
        Player lp = GameManager.Instance.LeftPlayer;

        if (rp != null && lp != null)
        {
            Vector3 rpPos = rp.transform.position;
            Vector3 lpPos = lp.transform.position;
            rp.transform.position = lpPos;
            lp.transform.position = rpPos;
        }

        Destroy(gameObject);
    }
}
