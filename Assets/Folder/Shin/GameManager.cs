using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Player _rightPlayer;
    [SerializeField] 
    private Player _leftPlayer;

    private static GameManager _instance;
    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindAnyObjectByType<GameManager>();
                if (_instance == null)
                {
                    GameObject go = new GameObject("GameManager");
                    _instance = go.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance != this)
        {
            Destroy(gameObject);
        }
    }

    public Player RightPlayer => _rightPlayer;
    public Player LeftPlayer => _leftPlayer;

    [Header("�Ǘ��֌W")]
    public bool _isGamePlay = false;
    public float _mileage = 0.0f;
    [SerializeField, Range(0.1f, 20.0f)] private float _mileageRatio = 1.0f;

    private void Update()
    {
        if (_isGamePlay)
        {
            _mileage += _mileageRatio * Time.deltaTime;
        }
    }

    private void SetTime(bool key)
    {
        _isGamePlay = key;

        if(!key)
        {
            _mileage = 0.0f;
        }
    }

}
