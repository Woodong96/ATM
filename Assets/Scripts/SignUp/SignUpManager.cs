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
            Debug.LogWarning("빈칸존재");
            return;
        }

       
        if (PlayerPrefs.HasKey(Idtxt))
        {
            Debug.LogWarning("이미 사용중인 ID");
            return;
        }

        if (Pstxt != PsConfirmtxt)
        {
            Debug.LogWarning("비밀번호와 비밀번호 확인이 다름");
            return;
        }
        if (IDInput.text.Length < 3 || IDInput.text.Length > 10)
        {
            Debug.LogWarning("아이디는 3글자~10글자사이");
            return;
        }
        if (UserName.text.Length < 2 || UserName.text.Length > 5)
        {
            Debug.LogWarning("유저이름은 2글자~5글자 사이");
            return;
        }


        PlayerPrefs.SetString(Idtxt, Pstxt);
        PlayerPrefs.Save();
        Signup_Page.SetActive(false);

        Debug.Log("사용자 등록 완료: " + Nametxt);
    }
}
