using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
public struct Money
{
    public int First_Balance {  get; set; }
    public int First_Cash { get; set; }

    public string User_Name { get; set; }
}

public class UserMoney : MonoBehaviour
{
    public static UserMoney instance;

    public Money money;
    public GameObject PutOut;
    public Text User_Name;
    
  
    private void Awake()
    {
        instance = this;

        money = new Money();
        money.First_Balance = PlayerPrefs.GetInt("Idtxt_Balance");
        money.First_Cash = PlayerPrefs.GetInt("Idtxt_Cash");
        money.User_Name = PlayerPrefs.GetString("Idtxt_Name");
        DontDestroyOnLoad(UserMoney.instance);
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
}
