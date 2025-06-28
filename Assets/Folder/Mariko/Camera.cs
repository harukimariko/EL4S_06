using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerCamera
{
    public class Camera : MonoBehaviour
    {
        [SerializeField] Transform _targetTransform;
        [SerializeField, Range(0.0f, 1.0f)] private float _lerpStrength = 0.8f;
        [SerializeField] bool _saveOffset;
        [SerializeField] Vector3 _offsetPosition;

        private void Start()
        {
            if (_saveOffset)
            {
                _offsetPosition = transform.position - _targetTransform.position;
            }
        }

        private void FixedUpdate()
        {

        }

        private void LateUpdate()
        {
            if (_targetTransform != null)
            {
                Vector3 targetPosition = _targetTransform.position + _offsetPosition;
                Vector3 position = Vector3.Lerp(targetPosition, transform.position, _lerpStrength);
                transform.position = position;
            }
        }
    }
}