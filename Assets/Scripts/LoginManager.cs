using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    //�α��� ȭ�� Root 
    public GameObject LoginView;

    public InputField inputField_ID;
    public InputField inputField_PW;
    public Button Button_Login;

    //Test�� ���� ���Ƿ� ����� ������ �߰�
    private string user = "User";
    private string password = "1234";

    /// 
    /// �α��� ��ư Ŭ���� ����
    /// 
    public void LoginButtonClick()
    {
        if (inputField_ID.text == user && inputField_PW.text == password)
        {
            Debug.Log("�α��� ����");
            SceneManager.LoadScene("ATMMainScene");
        }
        else
        {
            Debug.Log("�α��� ����");
        }
    }
}