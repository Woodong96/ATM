using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MoneyManager : UserMoney
{
    public Text Balance;
    public Text Cash;
    public Text Name;
    // Update is called once per frame
    private void Update()
    {
        Balance.text = money.First_Balance.ToString("C");
        Cash.text = money.First_Cash.ToString("C");
        Name.text = money.User_Name;

    }
}
