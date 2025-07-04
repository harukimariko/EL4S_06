using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPlayerController : MonoBehaviour
{

    [SerializeField] Vector3 _addForce = Vector3.zero;
    [SerializeField, Range(0.0f, 20.0f)] float _speedRatio = 5.0f;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // 例：キャラの移動に使う
        Vector3 direction = new Vector3(horizontal, 0, vertical);
        transform.Translate(direction * _speedRatio * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        
    }
}
