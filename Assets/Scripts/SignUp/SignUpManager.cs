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
   
    public void RegisterUser()
    {
        string Idtxt = IDInput.text;  
        string Pstxt = PSInput.text;    
        string PsConfirmtxt = PsConfirmInput.text;
        string Nametxt = UserName.text;

        if (string.IsNullOrEmpty(Idtxt) || string.IsNullOrEmpty(Pstxt) || string.IsNullOrEmpty(PsConfirmtxt) || string.IsNullOrEmpty(Nametxt))
        {
            Debug.LogWarning("��ĭ����");
            return;
        }

       
        if (PlayerPrefs.HasKey(Idtxt))
        {
            Debug.LogWarning("�̹� ������� ID");
            return;
        }

        if (Pstxt != PsConfirmtxt)
        {
            Debug.LogWarning("��й�ȣ�� ��й�ȣ Ȯ���� �ٸ�");
            return;
        }

        
        PlayerPrefs.SetString(Idtxt, Pstxt);
        PlayerPrefs.Save();
        Signup_Page.SetActive(false);

        Debug.Log("����� ��� �Ϸ�: " + Nametxt);
    }
}
