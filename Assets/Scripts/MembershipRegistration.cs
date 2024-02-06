using UnityEngine;
using UnityEngine.UI;

public class MembershipRegistration : MonoBehaviour
{
    public InputField IdInput;  //���̵� �Է� �ʵ�
    public InputField nameInput;   // �̸� �Է� �ʵ�
    public InputField passwordInput;   // ��й�ȣ �Է� �ʵ�
    public Button registerButton;      // ȸ�� ���� ��ư

    private void Start()
    {
        // ȸ�� ���� ��ư�� onClick �̺�Ʈ�� �Լ��� �����մϴ�.
        registerButton.onClick.AddListener(RegisterUser);
    }

    private void RegisterUser()
    {
        string id = IdInput.text;           //�Էµ� id 
        string username = nameInput.text;    // �Էµ� �̸�
        string password = passwordInput.text;    // �Էµ� ��й�ȣ

        if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(username))
        {
            Debug.LogWarning("���̵�, �̸��� ��й�ȣ�� ������� �� �����ϴ�.");
            return;
        }

        // id�� �̹� �����ϴ��� Ȯ��
        if (PlayerPrefs.HasKey(id))
        {
            Debug.LogWarning("�̹� ����ڰ� �����մϴ�.");
            return;
        }

        // PlayerPrefs�� ����Ͽ� ����� �����͸� ����
        PlayerPrefs.SetString(id, username);
        PlayerPrefs.SetString(id, password);
        PlayerPrefs.Save();

        Debug.Log("����� ��� �Ϸ�: " + username);
    }
}