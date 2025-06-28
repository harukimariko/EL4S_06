using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public Player Player;
    public Image itemIcon;

    private Sprite icon;

    void Start()
    {
        icon = null;
    }

    void Update()
    {
        GetItemInfo();
        UpdateItemUI();
    }

    private void GetItemInfo()
    {
        //Ç±Ç±Ç…èÓïÒéÊìæ
        if (Player._currentItem != null)
        {
            icon = Player._currentItem.Icon;
        }
        else
        {
            icon = null;
        }
    }

    private void UpdateItemUI()
    {
       itemIcon.sprite = icon;
    }
}
