using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    //로그인 화면 Root 

    public InputField inputField_ID;
    public InputField inputField_PW;
    public Button Button_Login;

    //Test를 위해 임의로 사용자 변수를 추가
    private string user = "qwer";
    private string password = "1234";

    /// 
    /// 로그인 버튼 클릭시 실행
    /// 
    public void LoginButtonClick()
    {
        if (inputField_ID.text == user && inputField_PW.text == password)
        {
            Debug.Log("로그인 성공");
            SceneManager.LoadScene("ATMMainScene");
        }
        else
        {
            Debug.Log("로그인 실패");
        }
    }
}