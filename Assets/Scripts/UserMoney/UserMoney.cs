using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UserMoney : MonoBehaviour
{
    public static UserMoney instance;
    public Text Balance;
    public Text Cash;

    public int First_Balance;
    public int First_Cash;
    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        Balance.text = First_Balance.ToString("N0");
        Cash.text = First_Cash.ToString("N0");
    }

}
