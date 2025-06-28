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

    [SerializeField] float _spawnTimer = 3;
    [SerializeField] float _countDownTimer = 0;

    private void Awake()
    {
        //  タイマーセット
        _countDownTimer = _spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        _countDownTimer -= Time.deltaTime;

        if (_countDownTimer <=0)
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

            _countDownTimer = _spawnTimer;
        }
    }
}
