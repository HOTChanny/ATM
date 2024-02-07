using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncreaseMoney_btn : MonoBehaviour
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


    void OnClick10()
    {
        balanceText.text = balance.ToString();
        cashText.text = cash.ToString();

        if (cash > balance)
        {
            balance = balance + 10000;
            cash = cash - 10000;
        }
        else
        {
            Debug.Log("�ܾ� ����");
        }
    }

        void OnClick30()
        {
            balanceText.text = balance.ToString();
            cashText.text = cash.ToString();

            if (cash > balance)
            {
                balance = balance + 30000;
                cash = cash - 30000;
            }
            else
            {
                Debug.Log("�ܾ� ����");
            }
        }
  

}
