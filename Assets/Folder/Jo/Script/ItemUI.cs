using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUI : MonoBehaviour
{
    public GameObject Player;
    public Image item1;
    public Image item2;
    public Image item3;
    public Image item4;

    public int itemIndex;

    void Start()
    {
        itemIndex = 0;
    }

    void Update()
    {
        GetItemInfo();
        UpdateItemUI();
    }

    private void GetItemInfo()
    {
        //Ç±Ç±Ç…èÓïÒéÊìæ


    }

    private void UpdateItemUI()
    {
        switch (itemIndex)
        {
            case 0:
                item1.gameObject.SetActive(false);
                item2.gameObject.SetActive(false);
                item3.gameObject.SetActive(false);
                item4.gameObject.SetActive(false);
                break;
            case 1:
                item1.gameObject.SetActive(true);
                item2.gameObject.SetActive(false);
                item3.gameObject.SetActive(false);
                item4.gameObject.SetActive(false);
                break;
            case 2:
                item1.gameObject.SetActive(false);
                item2.gameObject.SetActive(true);
                item3.gameObject.SetActive(false);
                item4.gameObject.SetActive(false);
                break;
            case 3:
                item1.gameObject.SetActive(false);
                item2.gameObject.SetActive(false);
                item3.gameObject.SetActive(true);
                item4.gameObject.SetActive(false);
                break;
            case 4:
                item1.gameObject.SetActive(false);
                item2.gameObject.SetActive(false);
                item3.gameObject.SetActive(false);
                item4.gameObject.SetActive(true);
                break;
            default:
                break;
        }
    }
}
