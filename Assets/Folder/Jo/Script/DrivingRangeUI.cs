using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrivingRangeUI : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public Text text;
    private float range;

    private Vector3 lastPos;
    private Vector3 nowPos;

    void Start()
    {
        range = 0f;
        lastPos = Vector3.zero;
        nowPos = Vector3.zero;
    }


    void Update()
    {
        UpdatePlayerPos();
        UpdateDrivingRange();
    }

    private void UpdatePlayerPos()
    {
        nowPos = player.transform.position;
    }

    private void UpdateDrivingRange()
    {
        float distance = Vector3.Distance(lastPos, nowPos);
        range += distance;

        text.text = (int)range+ " m";

        lastPos= nowPos;
    }
}
