using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecreasecreaseMoney_btn : MonoBehaviour
{
    //�Ա�_���� ��ư Ŭ����, �ܾ�+, ����-

    public Text balanceText;
    public Text cashText;

    int balance;
    int cash;


    private void Awake()
    {
        balance = 50000;
        cash = 100000;
    }
    private void Update()
    {
        balanceText.text = balance.ToString();
        cashText.text = cash.ToString();
    }



    public void OnClick10()
    {

        if (cash < balance)
        {
            balance = balance - 10000;
            cash = cash + 10000;
        }
        else
        {
            Debug.Log("�ܾ� ����");
        }
    }

    public void OnClick30()
    {


        if (cash < balance)
        {
            balance = balance - 30000;
            cash = cash + 30000;
        }
        else
        {
            Debug.Log("�ܾ� ����");
        }
    }

    public void OnClick50()
    {


        if (cash < balance)
        {
            balance = balance - 50000;
            cash = cash + 50000;
        }
        else
        {
            Debug.Log("�ܾ� ����");
        }
    }


}
