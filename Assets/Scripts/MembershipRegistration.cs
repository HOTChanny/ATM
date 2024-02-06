using UnityEngine;
using UnityEngine.UI;

public class MembershipRegistration : MonoBehaviour
{
    public InputField IdInput;  //아이디 입력 필드
    public InputField nameInput;   // 이름 입력 필드
    public InputField passwordInput;   // 비밀번호 입력 필드
    public Button registerButton;      // 회원 가입 버튼

    private void Start()
    {
        // 회원 가입 버튼의 onClick 이벤트에 함수를 연결합니다.
        registerButton.onClick.AddListener(RegisterUser);
    }

    private void RegisterUser()
    {
        string id = IdInput.text;           //입력된 id 
        string username = nameInput.text;    // 입력된 이름
        string password = passwordInput.text;    // 입력된 비밀번호

        if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
        {
            Debug.LogWarning("아이디, 이름과 비밀번호는 비어있을 수 없습니다.");
            return;
        }

        // id가 이미 존재하는지 확인
        if (PlayerPrefs.HasKey(id))
        {
            Debug.LogWarning("이미 사용자가 존재합니다.");
            return;
        }

        // PlayerPrefs를 사용하여 사용자 데이터를 저장
        PlayerPrefs.SetString(id, username);
        PlayerPrefs.SetString(id, password);
        PlayerPrefs.Save();

        Debug.Log("사용자 등록 완료: " + username);
    }
}