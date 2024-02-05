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
}

public class UserMoney : MonoBehaviour
{
    public static UserMoney instance;
    public Text Balance;
    public Text Cash;
    public Money money;
    public GameObject PutOut;
    
  
    private void Awake()
    {
        instance = this;

        money = new Money();
        money.First_Balance = 50000;
        money.First_Cash = 100000;
    }

    private void Update()
    {
        Balance.text = money.First_Balance.ToString("C");
        Cash.text = money.First_Cash.ToString("C");
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
