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
        if (money.First_Cash >= input)
        {
            money.First_Cash -= input;
            money.First_Balance += input;
        }
        else
        {
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
