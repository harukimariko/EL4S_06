using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetLight : MonoBehaviour
{
    [SerializeField] private float _respornPos;
    [SerializeField] private float _endPos;
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - _speed);

        if (transform.position.z <= _endPos)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, _respornPos);
        }
    }
}
