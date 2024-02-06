using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Withdraw : MonoBehaviour
{
    public InputField Withdraw_Money;
    private int _amount;
    public void Btn_1()
    {
        MoneyManager.instance.Withdraw_Money(10000);
    }
    public void Btn_2()
    {
        MoneyManager.instance.Withdraw_Money(30000);
    }

    public void Btn_3()
    {
        MoneyManager.instance.Withdraw_Money(50000);
    }

    public void Btn_4()
    {
        _amount = int.Parse(Withdraw_Money.text);
        MoneyManager.instance.Withdraw_Money(_amount);
    }
}
