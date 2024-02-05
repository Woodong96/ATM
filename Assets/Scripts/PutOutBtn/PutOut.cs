using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutOut : MonoBehaviour
{
    public GameObject Deposit;
    public GameObject Withdraw;
    public GameObject DepositSetting;
    // Start is called before the first frame update
    public void DepositBtnClick()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
        DepositSetting.SetActive(true);
    }

    public void WithdrawBtnClick()
    {
        Deposit.SetActive(false);
        Withdraw.SetActive(false);
    }
}
