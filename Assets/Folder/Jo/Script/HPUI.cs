using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPUI : MonoBehaviour
{
    public GameManager gameManager;
    public Image hpBar;
    public bool isPlayer1;

    public float hp;
    private float hpMax;

    void Start()
    {
        if (isPlayer1)
        {
            hpMax = 100f;//������GameManager����Player��HPMAX���擾
            hp = hpMax;
        }
        else
        {
            hpMax = 100f;//������GameManager����Player��HPMAX���擾
            hp = hpMax;
        }
    }

    void Update()
    {
        UpdatePlayerHP();
        UpdateHPUI();
    }

    private void UpdatePlayerHP()
    {
        if (isPlayer1)
        {
            //������GameManager����Player��HP���擾
        }
        else
        {
            //������GameManager����Player�̂��擾
        }
    }

    private void UpdateHPUI()
    {
        hpBar.fillAmount = hp / hpMax;
    }
}
