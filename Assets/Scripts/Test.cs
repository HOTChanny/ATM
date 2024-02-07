using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //��ǲ �ʵ� ������ �ʿ���.

public class Test : MonoBehaviour
{

    [SerializeField] private Text txt_money;
    [SerializeField] private InputField inputTxT_Money;
    private int current_Money;

    // Start is called before the first frame update

    public void Start()
    {
        current_Money = int.Parse(txt_money.text); //�ؽ�Ʈ�� �ԷµǾ��ִ� ������ ���� �� �ʱ�ȭ.
    }
    public void Input() //�Ա�
    {
        current_Money += int.Parse(inputTxT_Money.text); //�Է¹��� ������ ���ڸ� int�� ���ڷ� �ٲ���.

        txt_money.text = current_Money.ToString(); //intŸ���� string Ÿ������ �ٲپ� ȭ�鿡 �ݿ�.
    }

    public void Output() //���
    {

        current_Money -= int.Parse(inputTxT_Money.text); //������ ���ڸ� int�� ���ڷ� �ٲ���.

        txt_money.text = current_Money.ToString(); //intŸ���� string Ÿ������ �ٲ���

    }
}