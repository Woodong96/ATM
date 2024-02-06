using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Remittance : MonoBehaviour
{
    public InputField Remittance_Money;
    public InputField Remittance_Person;
    private int _amount;
    private string _ID;
    public void Send_money()
    {
        _amount = int.Parse(Remittance_Money.text);
        _ID = Remittance_Person.text;

        MoneyManager.instance.Remittance_Money(_ID, _amount);
    }
}
