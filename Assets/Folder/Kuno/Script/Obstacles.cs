using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private float _endPos;
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - _speed);

        if (transform.position.z <= _endPos)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 押し出す
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 100);
            Debug.Log("Playerに衝突しました。押し出します。");
        }
    }
}
