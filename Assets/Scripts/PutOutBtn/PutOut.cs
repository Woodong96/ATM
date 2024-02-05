using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutOut : MonoBehaviour
{
    public GameObject Deposit;
    public GameObject Withdraw;
    public GameObject DepositSetting;
    public GameObject CheckMoney;
    public GameObject WithdrawSetting;
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
        WithdrawSetting.SetActive(true);
    }


    public void Back()
    {
        Deposit.SetActive(true);
        Withdraw.SetActive(true);
        DepositSetting.SetActive(false);
        WithdrawSetting.SetActive(false);
    }

    public void CheckMoneyOn()
    {
        CheckMoney.SetActive(true);
    } 
    
    public void CheckMoneyOff()
    {
        CheckMoney.SetActive(false);
    }



}
