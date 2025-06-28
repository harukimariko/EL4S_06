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
            hpMax = 100f;//‚±‚±‚ÉGameManager‚©‚çPlayer‚ÌHPMAX‚ðŽæ“¾
            hp = hpMax;
        }
        else
        {
            hpMax = 100f;//‚±‚±‚ÉGameManager‚©‚çPlayer‚ÌHPMAX‚ðŽæ“¾
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
            //‚±‚±‚ÉGameManager‚©‚çPlayer‚ÌHP‚ðŽæ“¾
        }
        else
        {
            //‚±‚±‚ÉGameManager‚©‚çPlayer‚Ì‚ðŽæ“¾
        }
    }

    private void UpdateHPUI()
    {
        hpBar.fillAmount = hp / hpMax;
    }
}
