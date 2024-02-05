using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deposit : MonoBehaviour
{
    // Start is called before the first frame update

    public InputField Deposit_Money;
    private int _amount;
    public void Btn_1()
    {
        UserMoney.instance.Deposit_Money(10000);
    }
    public void Btn_2()
    {
        UserMoney.instance.Deposit_Money(30000);
    }

    public void Btn_3()
    {
        UserMoney.instance.Deposit_Money(50000);
    }

    public void Btn_4()
    {
        _amount = int.Parse(Deposit_Money.text);
        UserMoney.instance.Deposit_Money(_amount);
    }



}


