using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecreasecreaseMoney_btn : MonoBehaviour
{
    //입금_만원 버튼 클릭시, 잔액+, 현금-

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
            Debug.Log("잔액 부족");
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
            Debug.Log("잔액 부족");
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
            Debug.Log("잔액 부족");
        }
    }


}
