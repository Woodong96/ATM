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
        UserMoney.instance.Withdraw_Money(10000);
    }
    public void Btn_2()
    {
        UserMoney.instance.Withdraw_Money(30000);
    }

    public void Btn_3()
    {
        UserMoney.instance.Withdraw_Money(50000);
    }

    public void Btn_4()
    {
        _amount = int.Parse(Withdraw_Money.text);
        UserMoney.instance.Withdraw_Money(_amount);
    }
}
