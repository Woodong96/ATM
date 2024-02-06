using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignUpManager : MonoBehaviour
{
    public InputField IDInput;   
    public InputField PSInput;
    public InputField PsConfirmInput;
    public InputField UserName;
    public GameObject Signup_Page;
    public GameObject Error_Popup;
    public void RegisterUser()
    {
        string Idtxt = IDInput.text;  
        string Pstxt = PSInput.text;    
        string User_Name = UserName.text;
        string PsConfirmtxt = PsConfirmInput.text;
        string Nametxt = UserName.text;
        string Idtxt_Balance = Idtxt + "Balance";
        string Idtxt_Cash = Idtxt + "Cash";
        if (string.IsNullOrEmpty(Idtxt) || string.IsNullOrEmpty(Pstxt) || string.IsNullOrEmpty(PsConfirmtxt) || string.IsNullOrEmpty(Nametxt))
        {
            Debug.LogWarning("��ĭ����");
            Error_Popup.SetActive(true);
            return;
        }

       
        if (PlayerPrefs.HasKey(Idtxt))
        {
            Debug.LogWarning("�̹� ������� ID");
            Error_Popup.SetActive(true);
            return;
        }

        if (Pstxt != PsConfirmtxt)
        {
            Debug.LogWarning("��й�ȣ�� ��й�ȣ Ȯ���� �ٸ�");
            Error_Popup.SetActive(true);
            return;
        }
        if (IDInput.text.Length < 3 || IDInput.text.Length > 10)
        {
            Debug.LogWarning("���̵�� 3����~10���ڻ���");
            Error_Popup.SetActive(true);
            return;
        }
        if (UserName.text.Length < 2 || UserName.text.Length > 5)
        {
            Debug.LogWarning("�����̸��� 2����~5���� ����");
            Error_Popup.SetActive(true);
            return;
        }


        PlayerPrefs.SetString(Idtxt, Pstxt);
        PlayerPrefs.SetInt(Idtxt+"Balance", 50000);
        PlayerPrefs.SetInt(Idtxt+"Cash", 100000);
        PlayerPrefs.SetString(Idtxt+"Name", User_Name);
        PlayerPrefs.Save();
        Signup_Page.SetActive(false);

        Debug.Log("����� ��� �Ϸ�: " + Idtxt);
    }

    public void PopupOff()
    {
        Error_Popup.SetActive(false);
    }
}
