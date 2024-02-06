using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class MoneyUI : MonoBehaviour
{
    public Text Balance;  //»ó¼Ó X  Manager x => UI
    public Text Cash;
    public Text Name;
    // Update is called once per frame
    private void Update()
    {

        Balance.text = MoneyManager.instance.money.First_Balance.ToString("C");
        Cash.text = MoneyManager.instance.money.First_Cash.ToString("C");
        Name.text = MoneyManager.instance.money.User_Name;

    }
}
