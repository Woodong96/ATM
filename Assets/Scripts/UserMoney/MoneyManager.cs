using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.Windows;
public struct Money
{
    public int First_Balance {  get; set; }
    public int First_Cash { get; set; }

    public string User_Id { get; set; }
    public string User_Name { get; set; }
}

public class MoneyManager : MonoBehaviour   // 모노비헤이비어 때고 작동 확인(UI를 이코드에서 삭제)
{
    public static MoneyManager instance;

    public Money money;
    public GameObject PutOut;
    public Text User_Name;

    // 피드백
    // start씬에서는 유저확인만
    // 메인씬에서는 유저 기반으로 데이터관리만


    private void Awake()
    {
        if (null == instance)
        {
            instance = this;

     
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
          
            Destroy(this.gameObject);
        }
        
    }

    private void Update()
    {
       
        

    }
    public void Deposit_Money(int input)
    {
        Debug.Log(input);
        if (money.First_Cash >= input)
        {
            money.First_Cash -= input;
            money.First_Balance += input;
        }
        else
        {
            Debug.Log("123");
            PutOut.GetComponent<PutOut>().CheckMoneyOn();
        }


    } 
    public void Withdraw_Money(int input)
    {
        if (money.First_Balance >= input)
        {
            money.First_Cash += input;
            money.First_Balance -= input;
        }
        else
        {
            PutOut.GetComponent<PutOut>().CheckMoneyOn();
        }
    }

    public void Remittance_Money(string input ,int input2)
    {
        if (PlayerPrefs.HasKey(input) && input != money.User_Id)
        {
            if (money.First_Balance >= input2)
            {
                
                money.First_Balance -= input2;
                int Get_Num = PlayerPrefs.GetInt(input + "Balance") + input2;
                PlayerPrefs.SetInt(input + "Balance", Get_Num);
                PlayerPrefs.Save();

            }
            else
            {
                Debug.LogWarning("잔액을 확인하세요.");
                PutOut.GetComponent<PutOut>().CheckMoneyOn();
            }
        }
        else
        {
            Debug.LogWarning("받는이의 ID를 확인하세요.");
            return;
        }
    }

    public void SetData(string Idtxt)
    {
        money = new Money();
        money.First_Balance = PlayerPrefs.GetInt(Idtxt + "Balance");
        money.First_Cash = PlayerPrefs.GetInt(Idtxt + "Cash");
        money.User_Name = PlayerPrefs.GetString(Idtxt + "Name");
        money.User_Id = Idtxt;
    }

    public void SaveData()
    {
        string Idtxt = money.User_Id;
        PlayerPrefs.SetInt(Idtxt + "Balance", money.First_Balance);
        PlayerPrefs.SetInt(Idtxt + "Cash", money.First_Cash);
        PlayerPrefs.Save();
    }



}
