using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpanwner : MonoBehaviour
{
    [SerializeField] GameObject _gameObject1;
    [SerializeField] GameObject _gameObject2;
    [SerializeField] GameObject _gameObject3;
    [SerializeField] GameObject _gameObject4;
    [SerializeField] GameObject _gameObject5;

    [SerializeField] float _spawnTimer = 10;
    [SerializeField] float _timer = 0;

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime * _spawnTimer;

        if (_timer > _spawnTimer)
        {
            int rand = Random.Range(1, 6);

            switch (rand)
            {
                case 1:
                    Instantiate(_gameObject1);
                    break;
                case 2:
                    Instantiate(_gameObject2);
                    break;
                case 3:
                    Instantiate(_gameObject3);
                    break;
                case 4:
                    Instantiate(_gameObject4);
                    break;
                case 5:
                    Instantiate(_gameObject5);
                    break;
            }

            _timer = 0;
        }
    }
}
