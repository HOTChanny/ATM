using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //인풋 필드 쓰려면 필요함.

public class Test : MonoBehaviour
{

    [SerializeField] private Text txt_money;
    [SerializeField] private InputField inputTxT_Money;
    private int current_Money;

    // Start is called before the first frame update

    public void Start()
    {
        current_Money = int.Parse(txt_money.text); //텍스트에 입력되어있는 값으로 현재 돈 초기화.
    }
    public void Input() //입금
    {
        current_Money += int.Parse(inputTxT_Money.text); //입력받은 문자형 숫자를 int형 숫자로 바꿔줌.

        txt_money.text = current_Money.ToString(); //int타입을 string 타입으로 바꾸어 화면에 반영.
    }

    public void Output() //출금
    {

        current_Money -= int.Parse(inputTxT_Money.text); //문자형 숫자를 int형 숫자로 바꿔줌.

        txt_money.text = current_Money.ToString(); //int타입을 string 타입으로 바꿔줌

    }
}